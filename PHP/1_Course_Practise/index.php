<?php 
    echo "Hello World";
    $first_name = "Sharad";
    $last_name = "Gaur";
    $age = 10;
    $names = array('Sharad', 'Ravi', 'Rahul');
    echo $names[0];
    print_r( $names ) ;
    $min = 1;
    $max = 50;
    $guess = 4;
    $num = 16;
    $num = rand($min, $max);
    if ($guess < $min || $guess > $max)
        echo "<p>$guess is out of range.</p>";
    else if ($guess == $num)
        echo "<p>$guess is correct.</p>";
    else
        echo "<p>$guess is incorrect, and correct number is $num</p>";
    //echo 3**2+5*2;
    $a=2;
    echo ++$a + --$a;
?>
<br/>
<?="\nHello World 2"?>
<br>
<p>Hello, My name is <?php echo "\n" . $first_name . " " . $last_name . " and my age is " . $age ?></p>
<br/>
<p></p>