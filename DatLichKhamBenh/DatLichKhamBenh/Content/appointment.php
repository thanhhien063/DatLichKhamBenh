<!DOCTYPE html PUBLIC "#">
<html>
<head>
<meta HTTP-EQUIV="REFRESH" content="0; url=appointment-confirmation.html"> 

</head>
<body>
	<?php

		$name1=$_POST['first_name'];
		$name2=$_POST['last_name'];
		$Email=$_POST['email'];
		$phone=$_POST['phone'];
		$date=$_POST['date'];
		$gender=$_POST['gender'];
		$message=$_POST['message'];

		    
		    $body .= "First Name: " . $name1 . "\n"; 
		    $body .= "Last Name: " . $name2 . "\n"; 
		    $body .= "Email: " . $Email . "\n"; 
		    $body .= "Phone Number: " . $phone . "\n"; 
		    $body .= "Requested Date: " . $date . "\n"; 
		    $body .= "Gender: " . $gender . "\n"; 
		    $body .= "Message: " . $message . "\n"; 

		    //replace with your email
		    mail("demo@yourmail.com","New email",$body); 

		  
		?>

</body>
</html>

