import re
import sys
import webbrowser

def main(args):

	regex1 = ur".*(?<=com)"
	regex2 = ur"(?<=com).*"

	test_str = str(args[1])
	
	matchObj1 = re.search(regex1, test_str)
	string1 = matchObj1.group()
	
	matchObj2 = re.search(regex2, test_str)
	string2 = matchObj2.group()
	
	sciHub = string1 + '.sci-hub.cc' + string2
	
	webbrowser.open(sciHub)
	

if __name__ == '__main__':
	main(sys.argv)