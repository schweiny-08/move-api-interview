import { Box, Button, TextField, Typography } from '@mui/material';
import MovieFilter from '../Components/MovieFilter';
import { useState } from 'react';
import { keepPreviousData, useQuery } from '@tanstack/react-query';
import { fetchMovies } from '../api/movieApi';
import MovieList from '../Components/MovieList';

type QueryKey = {
  title: string;
  genre: string;
};

export default function MovieSearch() {
  const [title, setTitle] = useState<string | undefined>();
  const [genres, setGenres] = useState<string | undefined>();

  const {
    data: movies,
    isLoading,
    isError,
  } = useQuery(
    {
      queryKey: ['movies', title, genres],
      queryFn: fetchMovies,
    }
    // { keepPreviousData: true }
  );

  return (
    <Box
      display="flex"
      justifyContent="center"
      alignItems="flex-start"
      height="100vh"
      padding={3}
    >
      <Typography variant="h1">Welcome to the movie search engine!</Typography>
      <Typography>You can also filter by genre and title</Typography>
      <Box>
        <MovieFilter
          title={title}
          genres={genres}
          setTitle={setTitle}
          setGenres={setGenres}
        />
        <Box>
          <MovieList movies={movies} />
        </Box>
      </Box>
    </Box>
  );
}
