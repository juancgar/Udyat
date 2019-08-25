
import os
import json
import argparse

ap = argparse.ArgumentParser()
ap.add_argument("-p", "--PATH", required=True,
	help="path to Example Videos")
args = vars(ap.parse_args())


os.system("python predict_video.py -m model/model.h5 -l model/bin.pickle -i " + args["PATH"] + " -o output/output.divx -s 128")



        

