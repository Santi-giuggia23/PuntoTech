-- Actualiza las URL de imagen de los artículos existentes.
-- Las URL originales (images.samsung.com, motorola.cl, euronics.cz, intercompras.com,
-- cnnespanol2.files.wordpress.com) son de sitios de terceros que pueden mover o borrar
-- la imagen en cualquier momento, por eso dejaron de funcionar.
--
-- Se reemplazan por enlaces a Wikimedia Commons con el formato Special:FilePath, que es
-- el mecanismo que Wikimedia recomienda para enlazar imágenes directamente: no cambia
-- aunque el archivo se renombre o se mueva internamente, así que no debería volver a
-- vencerse. (La versión anterior de este script no funcionaba porque Commons devuelve
-- error 403 a los pedidos sin User-Agent; eso ya se corrigió en el código de Form1.cs.)
--
-- Ejecutar en SSMS conectado a la base CATALOGO_DB (mismo servidor .\SQLEXPRESS que usa
-- la aplicación).

USE CATALOGO_DB
GO

UPDATE ARTICULOS SET ImagenUrl = 'https://commons.wikimedia.org/wiki/Special:FilePath/Samsung%20Galaxy%20S10.jpg'
WHERE Codigo = 'S01'   -- Galaxy S10

UPDATE ARTICULOS SET ImagenUrl = 'https://commons.wikimedia.org/wiki/Special:FilePath/Moto%20G7%20Plus.png'
WHERE Codigo = 'M03'   -- Moto G Play 7ma Gen (no hay foto de la variante "Play" en Commons;
                       -- se usa la del Moto G7 Plus, de la misma familia y muy similar)

UPDATE ARTICULOS SET ImagenUrl = 'https://commons.wikimedia.org/wiki/Special:FilePath/Sony-PlayStation-4-PS4-Console-FL.jpg'
WHERE Codigo = 'S99'   -- Play 4 (PlayStation 4)

UPDATE ARTICULOS SET ImagenUrl = 'https://commons.wikimedia.org/wiki/Special:FilePath/Sony%20Bravia%2024%20Inch%20LED%20TV%20Model%20W60.jpg'
WHERE Codigo = 'S56'   -- Bravia 55 (foto genérica de un Sony Bravia, no hay una del modelo
                       -- de 55" exacto en Commons)

UPDATE ARTICULOS SET ImagenUrl = 'https://commons.wikimedia.org/wiki/Special:FilePath/AppleTV.png'
WHERE Codigo = 'A23'   -- Apple TV

UPDATE ARTICULOS SET ImagenUrl = 'https://commons.wikimedia.org/wiki/Special:FilePath/PlayStation%205%20and%20DualSense.jpg'
WHERE Codigo = 'C45'   -- Play 5 (PlayStation 5)

UPDATE ARTICULOS SET ImagenUrl = 'https://commons.wikimedia.org/wiki/Special:FilePath/PlayStation%205%20and%20DualSense.jpg'
WHERE Codigo = 'S65'   -- Play 5 (duplicado, misma consola)

UPDATE ARTICULOS SET ImagenUrl = 'https://commons.wikimedia.org/wiki/Special:FilePath/SAMSUNG%20Galaxy%20Watch.jpg'
WHERE Codigo = 'S012'  -- Smartwatch (Samsung)

UPDATE ARTICULOS SET ImagenUrl = 'https://commons.wikimedia.org/wiki/Special:FilePath/Bluetooth%20Speaker.jpg'
WHERE Codigo = 'S157'  -- Parlante (no hay foto de un modelo Sony puntual en Commons;
                       -- se usa una foto genérica de parlante bluetooth portátil)
GO

-- Verificación rápida:
SELECT Codigo, Nombre, ImagenUrl FROM ARTICULOS ORDER BY Codigo
