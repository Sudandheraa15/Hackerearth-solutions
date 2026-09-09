#include <stdio.h>

void solve() {
    int n;
    if (scanf("%d", &n) != 1) return;

    long long total_sum = 0;
    long long min_odd = 2e18;  
    int has_odd = 0;

    for (int i = 0; i < n; i++) {
        long long val;
        scanf("%lld", &val);
        total_sum += val; 
        if (val % 2 != 0) {
            has_odd = 1;
            if (val < min_odd) {
                min_odd = val;
            }
        }
    }  if (total_sum % 2 != 0) {
        printf("%lld\n", total_sum);
    }  else {
        if (has_odd) {
            printf("%lld\n", total_sum - min_odd);
        } else {
        
            printf("0\n");
        }
    }
}

int main() {
    int t;
    if (scanf("%d", &t) == 1) {
        while (t--) {
            solve();
        }
    }
    return 0;
}
