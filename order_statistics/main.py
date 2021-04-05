# Write a function that accepts an unordered array
# as input and return the n'th statistics
# For example, given [10, 2, 5, 6, 11, 3, 15],
# the first order statistic is the min value, which is 2
# the second order statistic is 3
# Therefore the n'th order statistic is the n'th smallest number in the array


def get_min(arr: [int], order: int = None) -> int:
    min_val = arr[0]
    for i in range(1, len(arr)):
        if arr[i] < min:
            min_val = arr[i]
    return min_val


if __name__ == '__main__':
    ns = [10, 2, 5, 6, 11, 3, 15]
    print(f"The first order statistic for {ns} is: {min(ns)}")
