import pandas as pd

files_to_convert = ['./data_in/description.csv', './data_in/test.csv']
output_locations = ['./data_out/description.csv', './data_out/test.csv']

for i in range(len(files_to_convert)):
    df = pd.read_csv(files_to_convert[i])
    for b_num in range(1, 9):
        df.loc[df['class'] == 'b' + str(b_num), 'class'] = 'bf'
    for b_num in range(9, 16):
        df.loc[df['class'] == 'b' + str(b_num), 'class'] = 'bh'
    df.loc[df['class'] == 'bwhite', 'class'] = 'bw'  # workaround
    df.loc[df['class'] == 'hole', 'class'] = 'h'  # workaround
    df.to_csv(output_locations[i], index=False)
