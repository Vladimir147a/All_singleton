package main

import (
	"fmt"
	"sync"
)

type Singleton struct {
	// Add fields as needed
}

var instance *Singleton
var once sync.Once

// GetInstance returns the singleton instance of Singleton
func GetInstance() *Singleton {
	once.Do(func() {
		instance = &Singleton{}
	})
	return instance
}

func main() {
	s1 := GetInstance()
	s2 := GetInstance()

	if s1 == s2 {
		fmt.Println("Both instances are the same.")
	} else {
		fmt.Println("Instances are different.")
	}
}
