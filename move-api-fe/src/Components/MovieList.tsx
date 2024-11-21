// src/components/MovieList/MovieList.tsx

import React from 'react';
import { Grid2, List, ListItem, ListItemText, Typography } from '@mui/material';
import Movie from '../Types/movie';
import MovieCard from './MovieCard';

type MovieListProps = {
  movies?: Movie[];
};

const MovieList: React.FC<MovieListProps> = ({ movies }) => {
  return (
    <Grid2 container spacing={2} padding={2}>
      {movies && movies.length > 0 ? (
        <Grid2 size={16}>
          {movies.map((movie, index) => (
            <MovieCard movie={movie} />
          ))}
        </Grid2>
      ) : (
        <Typography>No movies found</Typography>
      )}
    </Grid2>
  );
};

export default MovieList;
