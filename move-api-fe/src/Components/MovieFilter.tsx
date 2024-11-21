import {
  FormControl,
  InputLabel,
  MenuItem,
  Select,
  Stack,
  TextField,
} from '@mui/material';
import { useEffect, useState } from 'react';
import genresOptions from '../constants/genres';
import { Dispatch, SetStateAction } from 'react';

type MovieFilterProps = {
  title?: string;
  genres?: string;
  setTitle: Dispatch<SetStateAction<string | undefined>>;
  setGenres: Dispatch<SetStateAction<string | undefined>>;
};

export default function MovieFilter({
  title,
  genres,
  setTitle,
  setGenres,
}: MovieFilterProps) {
  const [debouncedTitle, setDebouncedTitle] = useState(title || '');

  useEffect(() => {
    const handler = setTimeout(() => {
      setTitle(debouncedTitle);
    }, 500);

    return () => {
      clearTimeout(handler);
    };
  }, [debouncedTitle, setTitle]);

  return (
    <Stack spacing="10px">
      <TextField
        label="Title"
        value={debouncedTitle}
        onChange={(e) => setDebouncedTitle(e.target.value)}
      />
      <FormControl fullWidth>
        <InputLabel>Genre</InputLabel>
        <Select
          value={genres}
          label="Genre"
          onChange={(e) => setGenres(e.target.value)}
        >
          <MenuItem value="">All</MenuItem>
          {genresOptions.map((genreOption) => (
            <MenuItem key={genreOption} value={genreOption}>
              {genreOption}
            </MenuItem>
          ))}
        </Select>
      </FormControl>
    </Stack>
  );
}
