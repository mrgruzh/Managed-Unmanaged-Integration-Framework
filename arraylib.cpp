#include "arraylib.h"
#include <iostream>

double findMin(double* array, int size) {
    double min = array[0];
    for (int i = 1; i < size; i++) {
        if (array[i] < min) {
            min = array[i];
        }
    }
    return min;
}

void findMinAndIndex(double* array, int size, double* min, int* indices) {
    *min = findMin(array, size);
    int count = 0;
    for (int i = 0; i < size; i++) {
        if (array[i] == *min) {
            indices[count] = i;
            count++;
        }
    }
}

void readArray(double* array, int size) {
    for (int i = 0; i < size; i++) {
        std::cin >> array[i];
    }
}

void printArray(double* array, int size) {
    for (int i = 0; i < size; i++) {
        std::cout << array[i] << " ";
    }
    std::cout << std::endl;
}
