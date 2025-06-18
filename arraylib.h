#ifndef ARRAYLIB_H
#define ARRAYLIB_H

extern "C" {
    double findMin(double* array, int size);
    void findMinAndIndex(double* array, int size, double* min, int* indices);
    void readArray(double* array, int size);
    void printArray(double* array, int size);
}

#endif
