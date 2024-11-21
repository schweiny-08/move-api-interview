import Movie from '../Types/movie';
import MovieFilters from '../Types/movieFilters';

export const fetchMovies = async ({
  queryKey,
}: {
  queryKey: [string, string | undefined, string | undefined];
}): Promise<Movie[]> => {
  const [_, title, genres] = queryKey;
  const queryParams = new URLSearchParams();
  if (title) {
    queryParams.append('title', title);
  }
  if (genres) {
    queryParams.append('genres', genres);
  }

  const response = await fetch(
    `http://localhost:5165/api/movies?${queryParams.toString()}`
  );
  if (!response.ok) throw new Error('Something went wrong');
  return response.json();
};
