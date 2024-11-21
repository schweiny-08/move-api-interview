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
        {/* Movie Poster */}
        {/* <CardMedia
          component="img"
          height="350"
          image={`https://via.placeholder.com/300x450.png?text=${movie.title}`} // Replace with actual image URL
          alt={movie.title}
        /> */}
        <CardContent sx={{ flexGrow: 1 }}>
          <Typography variant="h6" component="div" gutterBottom>
            {movie.title}
          </Typography>
          <Typography variant="body2" color="textSecondary">
            Genre: {movie.genres}
          </Typography>
        </CardContent>
      </Card>
    </Paper>
  );
};

export default MovieCard;
