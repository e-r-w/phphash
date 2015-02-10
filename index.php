<html>
 <head>
  <title>PHP Test</title>
 </head>
 <body>
 <?php 
   $hash = hash_hmac('sha256', 'The quick brown fox jumped over the lazy dog.', 'secret'); 
   echo $hash;
 ?> 
 </body>
</html>