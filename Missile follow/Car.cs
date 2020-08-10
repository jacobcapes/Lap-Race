using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Missile_follow
{
    class Car
    {
        // declare fields to use in the class
        public double xSpeed, ySpeed;
        public int x, y, width, height;//variables for the rectangle
        public Image car;//variable for the planet's image
        public Rectangle carRec;//variable for a rectangle to place our image in
        public int rotationAngle;
        public Matrix matrix;
        Point centre;
        public int carRotated;
        int carRotate;



        //Create a constructor (initialises the values of the fields)
        public Car()
        {
            x = 10;
            y = 360;
            width = 40;
            height = 40;
            rotationAngle = 0;
            car = Properties.Resources.car1;
            carRec = new Rectangle(x, y, width, height);
            xSpeed = 30 * (Math.Cos((carRotate - 90) * Math.PI / 180));
            ySpeed = 30 * (Math.Sin((carRotate + 90) * Math.PI / 180));
        }
        //methods
        public void drawCar(Graphics g)
        {
            //find the centre point of spaceRec
            centre = new Point(carRec.X + width / 2, carRec.Y + width / 2);
            //instantiate a Matrix object called matrix
            matrix = new Matrix();
            //rotate the matrix (spaceRec) about its centre
            matrix.RotateAt(rotationAngle, centre);
            //Set the current draw location to the rotated matrix point
            g.Transform = matrix;
            //draw the spaceship
            g.DrawImage(car, carRec);
        }
        public void MoveSpaceship(string move)
        {

            x += (int)xSpeed;//cast double to an integer value
            y -= (int)ySpeed;
            carRec.Location = new Point(x, y);//missiles new location


        }
    
            public void Rotatecar(int carRotate)
            {
            xSpeed = 10 * (Math.Cos((carRotate - 90) * Math.PI / 180));
            ySpeed = 10 * (Math.Sin((carRotate + 90) * Math.PI / 180));
        }
        
    
        }

    }

