# Udyat
Convotutional Neural Network to make action recognition and stop crime, also the data is save or store in a json for future implementations




In the root of the project

python index.py -p "path to the video"

To start the video analyzer

example videos paths:

"example_clips/lifting.mp4"

"example_clips/Robbery033.mp4"

"example_clips/Robbery137.mp4"

"example_clips/Robbery142.mp4"

"example_clips/soccer.mp4"

"example_clips/boxing.mp4"

to select specific video clips change the -i flag
or use 
python predict_video.py -m "model/model.h5" -l "model/bin.pickle" -i "example_clips/lifting.mp4" -o "output/output.mp4" -s 128