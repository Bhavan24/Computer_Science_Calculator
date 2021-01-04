def converter(user_input,i):
	dec = int(user_input, i)
	print(f"The decimal value is : {dec}")
	print(f"The binary  value is : {dec:08b}")
	print(f"The hexa    value is : {dec:x}")
	print(f"The octal   value is : {dec:o}")

def choiceConvertion(i):
	if i == 1:		
		dec = input("Enter your decimal number: ")
		converter(dec,0)
	elif i == 2:
		binary = input("Enter your binary number: ")
		converter(binary,2)
	elif i == 3:
		hexa = input("Enter your hexa number: ")
		converter(hexa,16)
	elif i == 4:
		octal = input("Enter your octal number: ")
		converter(octal,8)
	else:
		print("Invalid")

def numberConvertion():
	print("""
	1. Decimal Convertion
	2. Binary Convertion
	3. HexaDecimal Convertion
	4. Octal Convertion
	""")
	i = int(input("Enter your choice: "))
	choiceConvertion(i)

def nBitValues():
	n = int(input("Enter bits(n): "))
	print("Denary value: " , (10**n - 1))
	print("Binary value: " , (2**n - 1))
	print("Hexadecimal value: " , (16**n - 1))

def num_to_bin(num, length):
    if num < 0:
        num = 2**length+num
    base = bin(num)[2:]
    padding_size = length - len(base)
    return '0' * padding_size + base

def choiceOperations(i):
	if i == 1:		
		num1 = int(input("Enter your first number: "),2)
		num2 = int(input("Enter your second number: "),2)
		ans = (num1 & num2)	
		print(f'{ans:08b}')
	elif i == 2:
		num1 = int(input("Enter your first number: "),2)
		num2 = int(input("Enter your second number: "),2)
		ans = (num1 | num2)	
		print(f'{ans:08b}')
	elif i == 3:
		num = ~int(input("Enter your number: "),2)
		print(num_to_bin(num,8))
	else:
		print("Invalid")

def operations():
	print("""
	1. AND Operation
	2. OR Operation
	3. NOT Operation
	""")
	i = int(input("Enter your choice: "))
	choiceOperations(i)

def binaryCalculator():
	num1 = int(input("Enter your first number: "),2)
	num2 = int(input("Enter your second number: "),2)
	ope = input("Enter operator: ")

	if ope == "+":
		ans = (num1 + num2)	
	elif ope == "-":
		ans = (num1 - num2)	
	elif ope == "/":
		ans = (num1 / num2)	
	elif ope == "*":
		ans = (num1 * num2)	
	else:
		print("Invalid")

	print(f'{ans:08b}')	

def shifting():
	print("1.Right shift\n2.Left shift")
	i = int(input("Enter your choice: "))
	if i == 1:		
		num = int(input("Enter your binary number: "), 2)
		p = int(input("Enter positions: "))
		ans = num >> p
		print(ans)
	elif i == 2:
		num = int(input("Enter your binary number: "), 2)
		p = int(input("Enter positions: "))
		ans = num << p
		print(ans)
	else:
		print("Invalid")

def signedBinary():
	num = int(input("Enter decimal number: "))
	ans = num_to_bin(num,8)
	converter(ans,2)

def bicimalX():
	x = float(input("Enter fractional part (if number is 1.5 type 0.5): "))    
	i = 0
	while x > 0:
	    x = x * 2
	    y = int(x)
	    print(y, end = '')
	    x = (x - y)
	    i += 1
	if i < 4:
	    while i < 4:
	        print("0", end = '')
	        i += 1

def bicimal(x):
	x = float(x)
	i = 0
	num = ''
	while x > 0:
		x = x * 2
		y = int(x)
		num += str(y)
		x = (x - y)
		i += 1
	if i < 32:
		while i < 32:
			num += "0"
			i += 1
	return num

def ieee():
	num = input("Original number 	 : ")
	sign = input("Enter sign           : ")
	p = num.find('.')
	intPart = f'{int(num[:p]):b}'
	decPart = bicimal(num[p:])
	ans = intPart + decPart
	binNumber = intPart +'.'+ decPart
	x = ans.find("1")
	nor = ans[:x+1] + '.' + ans[x+1:]
	exp = binNumber.find('.') - nor.find('.')
	norNumber = nor + " X 2^" + str(exp)
	signbit = "0" if sign == "+" else "1"
	expDec = exp + 127
	expBit = f'{expDec:08b}'
	finalNum = signbit + expBit + ans[x+1:]

	print("Binary number        :", binNumber)
	print("Normalized number    :", norNumber)
	print("Mantissa  number     :", nor)
	print("IEEE754 Sign Bit     :", signbit)
	print("IEEE754 Exponent Bit :", expBit)
	print("IEEE754 Mantissa Bit :", ans[x+1:])
	print()
	for i in range(0,29,4):
		q = finalNum[i:i+4]        
		dec = int(q,2)
		x = f'{dec:X}'
		print(q + " --> ", end = x)
		print()

def binaryToDecimal(binary, length) :
    point = binary.find('.')
    if (point == -1) :
        point = length 
    intDecimal = 0
    fracDecimal = 0
    twos = 1
    for i in range(point-1, -1, -1) : 
        intDecimal += ((ord(binary[i]) - ord('0')) * twos) 
        twos *= 2
    twos = 2	
    for i in range(point + 1, length):		
        fracDecimal += ((ord(binary[i]) - ord('0')) / twos); 
        twos *= 2.0
    ans = intDecimal + fracDecimal	
    return ans


def ieeer():
	hex_n = input("Enter HEX number : ")
	ans = f"{int(hex_n,16):032b}"
	sign = "+ " if ans[0] == "0" else "- "
	exp = (int(ans[1:9],2)) - 127
	mantissa = "1." + ans[9:]

	print("IEEE754   Format :", ans)
	print("Normalized Number:", mantissa, " X  2^" + str(exp))

	if exp < 0:
		mantissa = mantissa.replace(".","")
		zeros = abs(exp + 1) * "0"
		bin_num = "0." + zeros + mantissa
		print("Bicimal Number   :", bin_num)
	else:
		mantissa = mantissa.replace(".","")
		bin_num = mantissa[:(exp+1)] + "." + mantissa[(exp+1):]
		print("Bicimal Number   :", bin_num)

	number = binaryToDecimal(bin_num, len(bin_num))
	finalNumber = sign + str(round(number, 4)) 
	print("Decimal number   :", finalNumber)

def dataStorage():
    print("""DATA STORAGE CONVERTION
    1.bit convertion
    2.nibble convertion
    3.byte convertion
    4.KB convertion
    5.MB convertion
    6.GB convertion
    """)
    inp = input("Enter your choice: ")
    if inp == "1":
        i = int(input("Enter bit: "))
        bitN = i
        nibbleN = bitN / 4
        byteN = bitN / 8
        KBN = byteN / 1024
        MBN = KBN / 1024
        GBN = MBN / 1024 
    elif inp == "2":
        i = int(input("Enter nibble: "))    
        nibbleN = i
        bitN = nibbleN * 4
        byteN = bitN / 8
        KBN = byteN / 1024
        MBN = KBN / 1024
        GBN = MBN / 1024 
    elif inp == "3":
        i = int(input("Enter byte: "))
        byteN = i
        bitN = byteN * 8
        nibbleN = bitN / 4
        KBN = byteN / 1024
        MBN = KBN / 1024
        GBN = MBN / 1024 
    elif inp == "4":
        i = int(input("Enter KB: "))
        KBN = i
        byteN = KBN * 1024
        bitN = byteN * 8
        nibbleN = bitN / 4
        MBN = KBN / 1024
        GBN = MBN / 1024 
    elif inp == "5":
        i = int(input("Enter MB: "))
        MBN = i
        KBN = MBN * 1024
        byteN = KBN * 1024
        bitN = byteN * 8
        nibbleN = bitN / 4
        GBN = MBN / 1024 
    elif inp == "6":
        i = int(input("Enter GB: "))
        GBN = i
        KBN = GBN * 1024 * 1024
        byteN = KBN * 1024
        bitN = byteN * 8
        nibbleN = bitN / 4
        MBN = KBN / 1024
    else:
        print("invalid")

    print(f"""
    bit = {bitN}
    nibble = {nibbleN}
    byte = {byteN}
    KB = {KBN}
    MB = {MBN}
    GB = {GBN}
    """)

def partitiontype(part_num):
    if (part_num == "00"):      txt = "Empty"           
    elif (part_num == "01"):    txt = "FAT12"
    elif (part_num == "04"):    txt = "FAT 16, 16 - 32 MB"
    elif (part_num == "06"):    txt = "FAT 16, 32 MB – 2GB"
    elif (part_num == "07"):    txt = "NTFS"
    elif ((part_num == "0b") or (part_num == "0B")):    txt = "FAT32"
    elif ((part_num == "0c") or (part_num == "0C")):    txt = "FAT32"
    elif (part_num == "82"):    txt = "Solaris x86"
    elif (part_num == "83"):    txt = "Linux"
    elif ((part_num == "a5") or (part_num == "A5")):    txt = "FreeBSD"
    elif ((part_num == "a6") or (part_num == "A6")):    txt = "OpenBSD"
    elif ((part_num == "a8") or (part_num == "A8")):    txt = "Mac OSX"
    else:   txt = "NOTHING"
    return txt    

def mbrPartition():
    bar = "------------------------------------------------------------------------------------"
    mbr = input("Enter Partition Entry(ex: 80 00 00): ")
    mbr = mbr.replace(" ","")
    x1 = mbr[0:2]
    x2 = mbr[2:4]
    x3 = mbr[4:6]
    x4 = mbr[6:8]
    x5 = mbr[8:10]
    x6 = mbr[10:12]
    x7 = mbr[12:14]
    x8 = mbr[14:16]
    x9 = mbr[16:18]
    x10 = mbr[18:20]
    x11 = mbr[20:22]
    x12 = mbr[22:24]
    x13 = mbr[24:26]
    x14 = mbr[26:28]
    x15 = mbr[28:30]
    x16 = mbr[30:32]
    n1 = int(x1)
    lba_string = x12 + x11 + x10 + x9
    lba_num = int(lba_string, 16)
    sec_string = x16 + x15 + x14 + x13
    sec_num = int(sec_string, 16)
    lba_kb = lba_num/2
    sec_kb = sec_num/2
    sec_mb = sec_kb/1024

    print(bar)
    if n1 > 0:
        print("Bootable Flag: Bootable                                                            |")
    if n1 <= 0:
        print("Bootable Flag: Non Bootable                                                        |")

    print(bar)
    print("Starting CHS Address: " , "| Little Endian = ", x2,x3,x4, "    | Big Endian = ", x4,x3,x2, "   |")
    print(bar)
    print("Partition type: ",partitiontype(x5),"                                                             |")
    print(bar)
    print("Ending CHS Address: " , "  | Little Endian = ", x6,x7,x8, "    | Big Endian = ", x8,x7,x6, "   |")
    print(bar)
    print("Starting LBA Address: " , "| Little Endian = ", x9,x10,x11,x12, " | Big Endian = ", x12,x11,x10,x9, "|")
    print()
    print("Dec Number = ",lba_num,"      |", "In KB = ", lba_kb,"                                            |")
    print(bar)
    print("Size in sectors: " , "     | Little Endian = ", x13,x14,x15,x16, "| Big Endian = ", x16,x15,x14,x13, " |")
    print()
    print("Dec Number = ",sec_num," |", "In KB = ", sec_kb,"           |"," In MB = ", sec_mb,"      |")
    print(bar)

def hex2ascii(hex_string):
    bytes_object = bytes.fromhex(hex_string)
    ascii_string = bytes_object.decode("ASCII")
    return ascii_string

def hex2dec(hex_string):
    dec_num = int(hex_string, 16)
    return dec_num

def PBS():
    pbs = input("Enter Partition Entry(ex: 80 00 00): ")
    pbs_list = pbs.split()
    x0 = pbs_list[0]
    x1 = pbs_list[1]
    x2 = pbs_list[2]
    x3 = pbs_list[3]
    x4 = pbs_list[4]
    x5 = pbs_list[5]
    x6 = pbs_list[6]
    x7 = pbs_list[7]
    x8 = pbs_list[8]
    x9 = pbs_list[9]
    x10 = pbs_list[10]
    x11 = pbs_list[11]
    x12 = pbs_list[12]
    x13 = pbs_list[13]
    x14 = pbs_list[14]
    x15 = pbs_list[15]
    x16 = pbs_list[16]
    x17 = pbs_list[17]
    x18 = pbs_list[18]
    x19 = pbs_list[19]
    x20 = pbs_list[20]
    x21 = pbs_list[21]
    x22 = pbs_list[22]
    x23 = pbs_list[23]
    x24 = pbs_list[24]
    x25 = pbs_list[25]
    x26 = pbs_list[26]
    x27 = pbs_list[27]
    x28 = pbs_list[28]
    x29 = pbs_list[29]
    x30 = pbs_list[30]
    x31 = pbs_list[31]
    x32 = pbs_list[32]
    x33 = pbs_list[33]
    x34 = pbs_list[34]
    x35 = pbs_list[35]

    oem_name = x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10
    bytes_per_sector = x12 + x11
    sector_per_cluster = x13
    size_in_secto_RA = x15 + x14
    nof = x16
    max_nof_rd = x18 + x17
    nos = x20 + x19
    media_type = x21
    size_of_each_fat = x23 + x22
    sectors_per_track = x25 + x24
    number_of_heads = x27 + x26
    sectors_before_partition= x31 + x30 + x29 + x28
    sectors_in_partition = x35 + x34 + x33 + x32

    print("---------------------------------------")
    print("OEM Name in ASCII         : ",hex2ascii(oem_name))
    print("Maximum number of files   : ",hex2dec(max_nof_rd))
    print("Sectors in partition(16)  : ",hex2dec(nos))
    print("Media type (DEC VALUE)    : ","fixed disk" if media_type == "F8" else "Removable disk")
    print("Sectors per track         : ",hex2dec(sectors_per_track))
    print("Number of heads           : ",hex2dec(number_of_heads))
    print("---------------------------------------")
    print("Bytes per sector          : ",hex2dec(bytes_per_sector) )
    print("Sector per cluster        : ",hex2dec(sector_per_cluster))
    print("Size in sectors RA        : ",hex2dec(size_in_secto_RA))
    print("Number of FATs            : ",hex2dec(nof))
    print("Sectors in partition(32)  : ",hex2dec(sectors_in_partition))
    print("Size of each FAT          : ",hex2dec(size_of_each_fat))
    print("Sectors before partition  : ",hex2dec(sectors_before_partition),"(",(hex2dec(sectors_before_partition) * 512),")")
    print("the first FAT starts at   : ",(hex2dec(sectors_before_partition) + hex2dec(size_in_secto_RA)))
    print("the second FAT starts at  : ",(hex2dec(sectors_before_partition) + hex2dec(size_in_secto_RA) + hex2dec(size_of_each_fat)))
    print("the root dir starts at    : ",(hex2dec(sectors_before_partition) + hex2dec(size_in_secto_RA) + hex2dec(size_of_each_fat) + hex2dec(size_of_each_fat)))
    print("---------------------------------------")

def memoryManagement():
    memory_list = []
    memory_list = [int(item) for item in input("Enter the list : ").split()]

    print('''   
    Best Fit  - 1
    First Fit - 2
    Worst Fit - 3
    ''')

    while True:

        fit_type = int(input("Fit type: ")) 
        user_memory = int(input("Enter the required memory: "))        

        if fit_type == 1:
            arranged_list = [x for x in memory_list]
            arranged_list.sort()
            for i in arranged_list: 
                if user_memory <= i:
                    print ("Best Fit is:", i)
                    break

        elif fit_type == 2:
            for i in memory_list: 
                if i >= user_memory:
                    print ("First Fit is:",i)
                    break                    

        elif fit_type == 3:
            largest = max(memory_list)
            print ("Worst Fit is:",largest)
            continue

        else:
            print("Wrong Number!")
            break  

def eight_bit_binary(ip):
    y = ""
    ip_list = [int(i) for i in ip.split(".")]
    for i in range(len(ip_list)):
        x = bin(ip_list[i]).replace("0b", "")
        if len(x) < 8:
            zeros = (8 - len(x)) * "0"
            x = zeros + x           
        y = y + x
    return y

def binary2Dec(string):
    for i in range(0,32,8):
        print(int(string[i:i+8],2), end=".")

def subnet(x,y):
    num = 0
    if (0 < x  < 127):    
        num = y - 8
    elif (127 < x < 192):    
        num = y - 16
    elif (191 < x < 224):    
        num = y - 24
    else:
        print("\nInvalid!")
    subnet = 2**num
    num1 = 32 - y
    host_subnet = 2**num1 - 2
    print()
    print("Maximum number of subnets:", subnet)
    print("Maximum number of hosts per subnet:", host_subnet)

def ipAddress():
    ip = input("Enter your IP address: ")
    inp = input("Enter network mask: ")
    if len(inp) < 3:
        nmask_number = int(inp)
    else:
        nmask = inp
        network_mask_binary = eight_bit_binary(nmask)
        nmask_number = network_mask_binary.index("0")    
    ip_in_binary = eight_bit_binary(ip)
    change = ip_in_binary[nmask_number:]
    unchanged = ip_in_binary[:nmask_number]
    new1 = len(change) * "0"
    new2 = len(change) * "1"
    new3 = ((len(change) - 1) * "0") + "1"
    new4 = ((len(change) - 1) * "1") + "0"
    network_address = unchanged + new1
    broadcast_address = unchanged + new2
    first_valid_host_ip = unchanged + new3
    last_valid_host_ip = unchanged + new4
    print("Network Address: ", end = "") 
    binary2Dec(network_address)
    print()
    print("Broadcast Address: ", end = "")
    binary2Dec(broadcast_address)
    print()
    print("First Valid Host ip: ",  end = "")
    binary2Dec(first_valid_host_ip)
    print()
    print("Last Valid Host ip: ", end = "")
    binary2Dec(last_valid_host_ip)
    z = ip.find(".")
    subnet(int(ip[:z]),nmask_number)

def selection():
	while True:		
	    print("""
	+-------------------------------+
	|       CSF CALCULATOR 			|
	+-------------------------------+
	| 1. Number Convertion          |
	| 2. Highest n bit Value        |
	| 3. Binary Operations(& | X)   |
	| 4. Binary Calculator          |
	| 5. Binary Shifting            |
	| 6. Signed Decimal convetion   |
	| 7. Bicimal Convertion         |
	| 8. IEEE754 (DEC TO HEX)       |
	| 9. IEEE754 (HEX TO DEC)       |
	|10. Data Storage Convertion    |
	|11. MBR partition              |
	|12. PBS                        |
	|13. Memory Management          |
	|14. IP Address                 |
	+-------------------------------+""")
	    u = input("Enter your choice: ")
	    try:
	        if u == "1":
	            numberConvertion()
	        elif u == "2":
	            nBitValues()
	        elif u == "3":
	            operations()
	        elif u == "4":
	            binaryCalculator()
	        elif u == "5":
	            shifting()
	        elif u == "6":
	            signedBinary()
	        elif u == "7":
	            bicimalX()
	        elif u == "8":
	            ieee()
	        elif u == "9":
	            ieeer()
	        elif u == "10":
	            dataStorage()
	        elif u == "11":
	            mbrPartition()
	        elif u == "12":
	            PBS()
	        elif u == "13":
	            memoryManagement()
	        elif u == "14":
	            ipAddress()
	        else:
	            print("Wrong input")
	            break
	    except Exception:
	        print("ERROR")
	        break 

def main():
	selection()
	

if __name__ == "__main__" :	main()