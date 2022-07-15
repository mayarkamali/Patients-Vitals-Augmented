# Patients-Vitals-Augmented

## Project Description
The idea is basically to utilize a mobile application to visualize the information related to hospitalized patients. The application could be used by the doctors or family visiting patients.

## Teammates
- Mayar Mostafa
- Joshua Stein
- Ali Bou Orm


## User Story

So when the application starts a camera view is shown to the user. He will scan a marker related to the patient. An Animated character (Nurse) is shown to the screen along with an AR overlayed Canvas showing patient related information in addition to two option buttons to display further info.


The character is animated in two modes. One in idle and one in talking. The characted speaks out the description of the patient. 
The user can additionaly navigate in the panels using the buttons in AR setup to explore patient's condition.

The application can be used for Doctors if they don't have much time and are in a hurry to follow up with the case. Or used by the patient's family to check on him and know their current physical state.


## Libraries and Platforms
- Unity : a cross-platform game engine
- Vuforia : an augmented reality software development kit for mobile devices that enables the creation of augmented reality applications.
- Mixamo : a library of thousands of full-body character animations, captured from professional motion actors. Used to get the character and its animation.


## Project Details:
- World canvas mode is used to overlay on the screen the panels in order to show menus in AR mode (instead of screen overlay)
- Patient class is implemented using Scriptable objects to facilitate the creation of multiple patients
