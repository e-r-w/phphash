<html>
 <head>
  <title>PHP Test</title>
 </head>
 <body>
 <?php
   
   $id = $_GET["id"];
   $ts= $_GET["ts"];
   $hash = $_GET["hash"];
   $data = $id . $ts;
   $myhash = hash_hmac('sha256', $data, 'secret');
   if($myhash == $hash){
     echo "valid, you are that guy I know who has the same secret key as me.";
   }else{
     echo "Hey, you don't even know the password";
   }
   
 ?> 
 </body>
</html>
