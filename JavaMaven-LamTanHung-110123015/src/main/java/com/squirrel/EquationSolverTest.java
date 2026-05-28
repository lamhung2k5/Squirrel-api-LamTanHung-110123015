package com.squirrel;

import static org.junit.Assert.assertEquals;
import org.junit.Test;

public class EquationSolverTest {
    EquationSolver solver = new EquationSolver();

    @Test
    public void testVoSoNghiem() {
        // a = 0, b = 0 -> Kết quả mong đợi là VSN
        assertEquals("VSN", solver.giaiPhuongTrinhBac1(0, 0));
    }

    @Test
    public void testVoNghiem() {
        // a = 0, b != 0 -> Kết quả mong đợi là VN
        assertEquals("VN", solver.giaiPhuongTrinhBac1(0, 5));
    }

    @Test
    public void testCoNghiem() {
        // a != 0 -> Kết quả mong đợi là CN
        assertEquals("CN", solver.giaiPhuongTrinhBac1(2, -4));
    }
}