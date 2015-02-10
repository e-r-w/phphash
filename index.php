<html>
 <head>
  <title>PHP Test</title>
 </head>
 <body>
 <?php
   
   $id = $_GET['id']
   $time = $_GET['time']
   $qshash = $_GET['hash']
   $hash = hash_hmac('sha256', "{$id}{$time}", 'secret');
   
   echo $qs;
 ?> 
 </body>
</html>