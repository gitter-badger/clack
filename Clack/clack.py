from tkinter import *
import sys
import tkinter.filedialog
root = Tk("Clack text editor")
root.title("Clack Text Editor")
text=Text(root)
text.grid()
root['background'] = '#292C2F'
text['background'] = '#292C2F'
menu = Menu(root)
root.geometry("640x450")
root.config(menu=menu)
root.option_add('*Font', 'Calibri')
filemenu = Menu(menu)
menu.add_cascade(label='File', menu=filemenu)
filemenu.add_command(label='New')
filemenu.add_command(label='Open...')
filemenu.add_command(label='Exit', command=root.quit)
helpmenu = Menu(menu)
menu.add_cascade(label='Help', menu=helpmenu)
helpmenu.add_command(label='About')
def saveas():
    global text
    t = text.get("1.0", "end-1c")
    savelocation = tkinter.filedialog.asksaveasfilename()
    file1 = open(savelocation, "w+")
    file1.write(t)
    file1.close()
button = Button(root, text="Save",
                background='black', foreground="white", command=saveas)
button.grid()
root.mainloop()
