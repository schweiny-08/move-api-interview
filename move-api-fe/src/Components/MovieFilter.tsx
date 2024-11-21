import {
  FormControl,
  InputLabel,
  MenuItem,
  Select,
  Stack,
  TextField,
} from '@mui/material';
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
  return (
    <Stack spacing="10px">
      <TextField
        label="Title"
        value={title}
        onChange={(e) => setTitle(e.target.value)}
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
