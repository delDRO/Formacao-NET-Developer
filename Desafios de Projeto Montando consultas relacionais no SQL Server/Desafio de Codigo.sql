/*-- 1 --
SELECT * FROM Filmes
--
SELECT 
	Nome,
	Ano
FROM Filmes

-- 2 --
SELECT * FROM Filmes 
ORDER BY ('Ano')
--
SELECT
	Nome,
	Ano
FROM Filmes
ORDER BY ('Ano')

-- 3 --
SELECT * FROM Filmes


-- 4 --
SELECT * FROM Filmes
WHERE Ano = '1997'

-- 5 --
SELECT * FROM Filmes
WHERE Ano > '2000'

-- 6 --
SELECT * FROM Filmes
WHERE Duracao > '100' AND Duracao < '150'
ORDER BY ('Duracao')

-- 7 -- Não funciona, não existe a coluna "quantidade"
SELECT 
	Ano,
	Quantidade
FROM Filmes
GROUP BY ('Ano')

-- 8 --
SELECT 
	PrimeiroNome,
	UltimoNome,
	Genero
FROM Atores
WHERE Genero = 'M'

-- 9 --
SELECT 
	PrimeiroNome,
	UltimoNome,
	Genero
FROM Atores
WHERE Genero = 'F'

-- 10 --
SELECT
	IdFilme,
	IdGenero
FROM FilmesGenero
*/
-- 11 --
SELECT 
	*,
	d.Genero AS 'Genero Filme',
	b.Nome
FROM [Filmes].[dbo].FilmesGenero f
JOIN [Filmes].[dbo].[Generos] d ON f.IdGenero = d.Id
JOIN [Filmes].[dbo].[Filmes] b ON b.Id = f.IdFilme
--WHERE IdGenero = 'Mistério'

-- 12 --
SELECT
	q.Nome,
	e.PrimeiroNome,
	e.UltimoNome,
	Papel
FROM [Filmes].[dbo].[Filmes] q
JOIN [Filmes].[dbo].[ElencoFilme] w ON w.IdFilme = q.Id
JOIN [Filmes].[dbo].[Atores] e ON e.Id = w.IdAtor