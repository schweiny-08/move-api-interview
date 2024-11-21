import React from 'react';
import logo from './logo.svg';
import './App.css';
import MovieSearch from './Pages/MoveSearch';
import { Container } from '@mui/material';
import { QueryClient, QueryClientProvider } from '@tanstack/react-query';

const queryClient = new QueryClient();

function App() {
  return (
    <QueryClientProvider client={queryClient}>
      <Container>
        <MovieSearch />
      </Container>
    </QueryClientProvider>
  );
}

export default App;
