// src/components/MovieList/MovieList.tsx

import React from 'react';
import { List, ListItem, ListItemText, Typography } from '@mui/material';
import Movie from '../Types/movie';
import MovieCard from './MovieCard';

type MovieListProps = {
  movies?: Movie[];
};

const MovieList: React.FC<MovieListProps> = ({ movies }) => {
  return (
    <div>
      {movies && movies.length > 0 ? (
        <List>
          {movies.map((movie, index) => (
            <ListItem key={index}>
              <MovieCard movie={movie} />
            </ListItem>
          ))}
        </List>
      ) : (
        <Typography>No movies found</Typography>
      )}
    </div>
  );
};

export default MovieList;
