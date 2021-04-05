def partition(arr: [int], l, r) -> int:
    pivot = arr[r]
    i = l-1
    j = l
    # n = r
    while j < r:
        if arr[j] < pivot:
            i += 1
            tmp = arr[j]
            arr[j] = arr[i]
            arr[i] = tmp
        j += 1
    # j -= 1
    while j > i + 1:
        arr[j] = arr[j-1]
        j -= 1
    # for p in range(1, r-i-1):
    #     arr[-p] = arr[-(p+1)]
    arr[i + 1] = pivot
    return i + 1


def sort(arr: [int], l: int = None, r: int = None):
    if l is None:
        l_idx = 0
    else:
        l_idx = l

    if r is None:
        r_idx = len(arr) - 1
    else:
        r_idx = r

    if r_idx <= l_idx:
        return

    p_idx = partition(arr, l_idx, r_idx)

    sort(arr, l, p_idx - 1)
    sort(arr, p_idx + 1, r)


if __name__ == '__main__':
    my_arr = [3, 7, 1, 5, 8, 12, 13, 2, 6]
    sort(my_arr)
    my_arr2 = [12, -3, 6, -25, 22, 1, 44, 25, 3, 7, 18]
    sort(my_arr2)
    print("Done")
