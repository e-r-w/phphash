<html>
 <head>
  <title>PHP Test</title>
 </head>
 <body>
 <?php
   $qs = $_SERVER['QUERY_STRING']
   $id = $_GET['id']
   $time = $_GET['time']
   $qshash = $_GET['hash']
   $hash = hash_hmac('sha256', "{$id}{$time}", 'secret');
   
   echo $hash;
 ?> 
 </body>
</html>