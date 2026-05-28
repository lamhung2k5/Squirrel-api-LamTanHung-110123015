package com.squirrel;

import static org.junit.Assert.assertEquals;
import org.junit.Test;

public class EquationSolverTest {
    EquationSolver solver = new EquationSolver();

    @Test
    public void testVoSoNghiem() {
        String ketQua = solver.giaiPhuongTrinhBac1(0, 0);
        System.out.println("Kết quả test 1 (a=0, b=0) là: " + ketQua);
        assertEquals("VSN", ketQua);
    }

    @Test
    public void testVoNghiem() {
        String ketQua = solver.giaiPhuongTrinhBac1(0, 5);
        System.out.println("Kết quả test 2 (a=0, b=5) là: " + ketQua);
        assertEquals("VN", ketQua);
    }

    @Test
    public void testCoNghiem() {
        String ketQua = solver.giaiPhuongTrinhBac1(2, -4);
        System.out.println("Kết quả test 3 (a=2, b=-4) là: " + ketQua);
        assertEquals("CN", ketQua);
    }
}