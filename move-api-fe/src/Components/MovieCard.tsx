// src/components/MovieCard/MovieCard.tsx

import React from 'react';
import { Card, CardContent, CardMedia, Typography, Paper } from '@mui/material';
import Movie from '../Types/movie';

type MovieCardProps = {
  movie: Movie;
};

const MovieCard: React.FC<MovieCardProps> = ({ movie }) => {
  return (
    <Paper elevation={3} sx={{ margin: 2 }}>
      <Card sx={{ display: 'flex', flexDirection: 'column', height: '100%' }}>
        <CardContent sx={{ flexGrow: 1 }}>
          <Typography variant="h6" component="div" gutterBottom>
            {movie.title}
          </Typography>
          <Typography variant="body2" color="textSecondary">
            Release Year: {movie.year}
          </Typography>
          <Typography variant="body2" color="textSecondary">
            Genre: {movie.genres.join(', ')}
          </Typography>
          <Typography variant="body2" color="textSecondary">
            Director: {movie.director}
          </Typography>
          <Typography variant="body2" color="textSecondary">
            Main Actors: {movie.actors.join(', ')}
          </Typography>
          <Typography variant="body2" color="textSecondary">
            Rating: {movie.rating}
          </Typography>
        </CardContent>
      </Card>
    </Paper>
  );
};

export default MovieCard;
