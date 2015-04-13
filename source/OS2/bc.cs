-AC -LB -S0x4000

(-W1 -Za -DOS2 -I. -Ios2
main.c util.c number.c storage.c load.c execute.c global.c os2\getopt.c
)

(-W1 -Za -DOS2 -I. -Ios2 (-d bc.y))
(-W1 -Za -DOS2 -I. -Ios2 (-I8 scan.l))

os2\bc.exe
os2\bc.def

