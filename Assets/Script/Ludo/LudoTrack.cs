using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LudoTrack
{
    public static Vector2Int pos(string color, int steps, int ordinal) {
        if (color == "Red") {
            if (steps == 0) {
                if (ordinal == 1) {
                    return new Vector2Int(-5, -4);
                } else if (ordinal == 2) {
                    return new Vector2Int(-4, -4);
                } else if (ordinal == 3) {
                    return new Vector2Int(-5, -5);
                } else if (ordinal == 4) {
                    return new Vector2Int(-4, -5);
                } else {
                    return new Vector2Int(0, 0);
                }
            } else if (steps == 1) {
                return new Vector2Int(-1, -6);
            } else if (steps == 2) {
                return new Vector2Int(-1, -5);
            } else if (steps == 3) {
                return new Vector2Int(-1, -4);
            } else if (steps == 4) {
                return new Vector2Int(-1, -3);
            } else if (steps == 5) {
                return new Vector2Int(-1, -2);
            } else if (steps == 6) {
                return new Vector2Int(-2, -1);
            } else if (steps == 7) {
                return new Vector2Int(-3, -1);
            } else if (steps == 8) {
                return new Vector2Int(-4, -1);
            } else if (steps == 9) {
                return new Vector2Int(-5, -1);
            } else if (steps == 10) {
                return new Vector2Int(-6, -1);
            } else if (steps == 11) {
                return new Vector2Int(-7, -1);
            } else if (steps == 12) {
                return new Vector2Int(-7, 0);
            } else if (steps == 13) {
                return new Vector2Int(-7, 1);
            } else if (steps == 14) {
                return new Vector2Int(-6, 1);
            } else if (steps == 15) {
                return new Vector2Int(-5, 1);
            } else if (steps == 16) {
                return new Vector2Int(-4, 1);
            } else if (steps == 17) {
                return new Vector2Int(-3, 1);
            } else if (steps == 18) {
                return new Vector2Int(-2, 1);
            } else if (steps == 19) {
                return new Vector2Int(-1, 2);
            } else if (steps == 20) {
                return new Vector2Int(-1, 3);
            } else if (steps == 21) {
                return new Vector2Int(-1, 4);
            } else if (steps == 22) {
                return new Vector2Int(-1, 5);
            } else if (steps == 23) {
                return new Vector2Int(-1, 6);
            } else if (steps == 24) {
                return new Vector2Int(-1, 7);
            } else if (steps == 25) {
                return new Vector2Int(0, 7);
            } else if (steps == 26) {
                return new Vector2Int(1, 7);
            } else if (steps == 27) {
                return new Vector2Int(1, 6);
            } else if (steps == 28) {
                return new Vector2Int(1, 5);
            } else if (steps == 29) {
                return new Vector2Int(1, 4);
            } else if (steps == 30) {
                return new Vector2Int(1, 3);
            } else if (steps == 31) {
                return new Vector2Int(1, 2);
            } else if (steps == 32) {
                return new Vector2Int(2, 1);
            } else if (steps == 33) {
                return new Vector2Int(3, 1);
            } else if (steps == 34) {
                return new Vector2Int(4, 1);
            } else if (steps == 35) {
                return new Vector2Int(5, 1);
            } else if (steps == 36) {
                return new Vector2Int(6, 1);
            } else if (steps == 37) {
                return new Vector2Int(7, 1);
            } else if (steps == 38) {
                return new Vector2Int(7, 0);
            } else if (steps == 39) {
                return new Vector2Int(7, -1);
            } else if (steps == 40) {
                return new Vector2Int(6, -1);
            } else if (steps == 41) {
                return new Vector2Int(5, -1);
            } else if (steps == 42) {
                return new Vector2Int(4, -1);
            } else if (steps == 43) {
                return new Vector2Int(3, -1);
            } else if (steps == 44) {
                return new Vector2Int(2, -1);
            } else if (steps == 45) {
                return new Vector2Int(1, -2);
            } else if (steps == 46) {
                return new Vector2Int(1, -3);
            } else if (steps == 47) {
                return new Vector2Int(1, -4);
            } else if (steps == 48) {
                return new Vector2Int(1, -5);
            } else if (steps == 49) {
                return new Vector2Int(1, -6);
            } else if (steps == 50) {
                return new Vector2Int(1, -7);
            } else if (steps == 51) {
                return new Vector2Int(0, -7);
            } else if (steps == 52) {
                return new Vector2Int(0, -6);
            } else if (steps == 53) {
                return new Vector2Int(0, -5);
            } else if (steps == 54) {
                return new Vector2Int(0, -4);
            } else if (steps == 55) {
                return new Vector2Int(0, -3);
            } else if (steps == 56) {
                return new Vector2Int(0, -2);
            } else if (steps == 57) {
                return new Vector2Int(0, -1);
            } else {
                return new Vector2Int(0, 0);
            }
        } else if (color == "Yellow") {
            if (steps == 0) {
                if (ordinal == 1) {
                    return new Vector2Int(5, -4);
                } else if (ordinal == 2) {
                    return new Vector2Int(4, -4);
                } else if (ordinal == 3) {
                    return new Vector2Int(5, -5);
                } else if (ordinal == 4) {
                    return new Vector2Int(4, -5);
                } else {
                    return new Vector2Int(0, 0);
                }
            } else if (steps == 1) {
                return new Vector2Int(6, -1);
            } else if (steps == 2) {
                return new Vector2Int(5, -1);
            } else if (steps == 3) {
                return new Vector2Int(4, -1);
            } else if (steps == 4) {
                return new Vector2Int(3, -1);
            } else if (steps == 5) {
                return new Vector2Int(2, -1);
            } else if (steps == 6) {
                return new Vector2Int(1, -2);
            } else if (steps == 7) {
                return new Vector2Int(1, -3);
            } else if (steps == 8) {
                return new Vector2Int(1, -4);
            } else if (steps == 9) {
                return new Vector2Int(1, -5);
            } else if (steps == 10) {
                return new Vector2Int(1, -6);
            } else if (steps == 11) {
                return new Vector2Int(1, -7);
            } else if (steps == 12) {
                return new Vector2Int(0, -7);
            } else if (steps == 13) {
                return new Vector2Int(-1, -7);
            } else if (steps == 14) {
                return new Vector2Int(-1, -6);
            } else if (steps == 15) {
                return new Vector2Int(-1, -5);
            } else if (steps == 16) {
                return new Vector2Int(-1, -4);
            } else if (steps == 17) {
                return new Vector2Int(-1, -3);
            } else if (steps == 18) {
                return new Vector2Int(-1, -2);
            } else if (steps == 19) {
                return new Vector2Int(-2, -1);
            } else if (steps == 20) {
                return new Vector2Int(-3, -1);
            } else if (steps == 21) {
                return new Vector2Int(-4, -1);
            } else if (steps == 22) {
                return new Vector2Int(-5, -1);
            } else if (steps == 23) {
                return new Vector2Int(-6, -1);
            } else if (steps == 24) {
                return new Vector2Int(-7, -1);
            } else if (steps == 25) {
                return new Vector2Int(-7, 0);
            } else if (steps == 26) {
                return new Vector2Int(-7, 1);
            } else if (steps == 27) {
                return new Vector2Int(-6, 1);
            } else if (steps == 28) {
                return new Vector2Int(-5, 1);
            } else if (steps == 29) {
                return new Vector2Int(-4, 1);
            } else if (steps == 30) {
                return new Vector2Int(-3, 1);
            } else if (steps == 31) {
                return new Vector2Int(-2, 1);
            } else if (steps == 32) {
                return new Vector2Int(-1, 2);
            } else if (steps == 33) {
                return new Vector2Int(-1, 3);
            } else if (steps == 34) {
                return new Vector2Int(-1, 4);
            } else if (steps == 35) {
                return new Vector2Int(-1, 5);
            } else if (steps == 36) {
                return new Vector2Int(-1, 6);
            } else if (steps == 37) {
                return new Vector2Int(-1, 7);
            } else if (steps == 38) {
                return new Vector2Int(0, 7);
            } else if (steps == 39) {
                return new Vector2Int(1, 7);
            } else if (steps == 40) {
                return new Vector2Int(1, 6);
            } else if (steps == 41) {
                return new Vector2Int(1, 5);
            } else if (steps == 42) {
                return new Vector2Int(1, 4);
            } else if (steps == 43) {
                return new Vector2Int(1, 3);
            } else if (steps == 44) {
                return new Vector2Int(1, 2);
            } else if (steps == 45) {
                return new Vector2Int(2, 1);
            } else if (steps == 46) {
                return new Vector2Int(3, 1);
            } else if (steps == 47) {
                return new Vector2Int(4, 1);
            } else if (steps == 48) {
                return new Vector2Int(5, 1);
            } else if (steps == 49) {
                return new Vector2Int(6, 1);
            } else if (steps == 50) {
                return new Vector2Int(7, 1);
            } else if (steps == 51) {
                return new Vector2Int(7, 0);
            } else if (steps == 52) {
                return new Vector2Int(6, 0);
            } else if (steps == 53) {
                return new Vector2Int(5, 0);
            } else if (steps == 54) {
                return new Vector2Int(4, 0);
            } else if (steps == 55) {
                return new Vector2Int(3, 0);
            } else if (steps == 56) {
                return new Vector2Int(2, 0);
            } else if (steps == 57) {
                return new Vector2Int(1, 0);
            } else {
                return new Vector2Int(0, 0);
            }
        } else if (color == "Green") {
            if (steps == 0) {
                if (ordinal == 1) {
                    return new Vector2Int(-5, 4);
                } else if (ordinal == 2) {
                    return new Vector2Int(-4, 4);
                } else if (ordinal == 3) {
                    return new Vector2Int(-5, 5);
                } else if (ordinal == 4) {
                    return new Vector2Int(-4, 5);
                } else {
                    return new Vector2Int(0, 0);
                }
            } else if (steps == 1) {
                return new Vector2Int(-6, 1);
            } else if (steps == 2) {
                return new Vector2Int(-5, 1);
            } else if (steps == 3) {
                return new Vector2Int(-4, 1);
            } else if (steps == 4) {
                return new Vector2Int(-3, 1);
            } else if (steps == 5) {
                return new Vector2Int(-2, 1);
            } else if (steps == 6) {
                return new Vector2Int(-1, 2);
            } else if (steps == 7) {
                return new Vector2Int(-1, 3);
            } else if (steps == 8) {
                return new Vector2Int(-1, 4);
            } else if (steps == 9) {
                return new Vector2Int(-1, 5);
            } else if (steps == 10) {
                return new Vector2Int(-1, 6);
            } else if (steps == 11) {
                return new Vector2Int(-1, 7);
            } else if (steps == 12) {
                return new Vector2Int(0, 7);
            } else if (steps == 13) {
                return new Vector2Int(1, 7);
            } else if (steps == 14) {
                return new Vector2Int(1, 6);
            } else if (steps == 15) {
                return new Vector2Int(1, 5);
            } else if (steps == 16) {
                return new Vector2Int(1, 4);
            } else if (steps == 17) {
                return new Vector2Int(1, 3);
            } else if (steps == 18) {
                return new Vector2Int(1, 2);
            } else if (steps == 19) {
                return new Vector2Int(2, 1);
            } else if (steps == 20) {
                return new Vector2Int(3, 1);
            } else if (steps == 21) {
                return new Vector2Int(4, 1);
            } else if (steps == 22) {
                return new Vector2Int(5, 1);
            } else if (steps == 23) {
                return new Vector2Int(6, 1);
            } else if (steps == 24) {
                return new Vector2Int(7, 1);
            } else if (steps == 25) {
                return new Vector2Int(7, 0);
            } else if (steps == 26) {
                return new Vector2Int(7, -1);
            } else if (steps == 27) {
                return new Vector2Int(6, -1);
            } else if (steps == 28) {
                return new Vector2Int(5, -1);
            } else if (steps == 29) {
                return new Vector2Int(4, -1);
            } else if (steps == 30) {
                return new Vector2Int(3, -1);
            } else if (steps == 31) {
                return new Vector2Int(2, -1);
            } else if (steps == 32) {
                return new Vector2Int(1, -2);
            } else if (steps == 33) {
                return new Vector2Int(1, -3);
            } else if (steps == 34) {
                return new Vector2Int(1, -4);
            } else if (steps == 35) {
                return new Vector2Int(1, -5);
            } else if (steps == 36) {
                return new Vector2Int(1, -6);
            } else if (steps == 37) {
                return new Vector2Int(1, -7);
            } else if (steps == 38) {
                return new Vector2Int(0, -7);
            } else if (steps == 39) {
                return new Vector2Int(-1, -7);
            } else if (steps == 40) {
                return new Vector2Int(-1, -6);
            } else if (steps == 41) {
                return new Vector2Int(-1, -5);
            } else if (steps == 42) {
                return new Vector2Int(-1, -4);
            } else if (steps == 43) {
                return new Vector2Int(-1, -3);
            } else if (steps == 44) {
                return new Vector2Int(-1, -2);
            } else if (steps == 45) {
                return new Vector2Int(-2, -1);
            } else if (steps == 46) {
                return new Vector2Int(-3, -1);
            } else if (steps == 47) {
                return new Vector2Int(-4, -1);
            } else if (steps == 48) {
                return new Vector2Int(-5, -1);
            } else if (steps == 49) {
                return new Vector2Int(-6, -1);
            } else if (steps == 50) {
                return new Vector2Int(-7, -1);
            } else if (steps == 51) {
                return new Vector2Int(-7, 0);
            } else if (steps == 52) {
                return new Vector2Int(-6, 0);
            } else if (steps == 53) {
                return new Vector2Int(-5, 0);
            } else if (steps == 54) {
                return new Vector2Int(-4, 0);
            } else if (steps == 55) {
                return new Vector2Int(-3, 0);
            } else if (steps == 56) {
                return new Vector2Int(-2, 0);
            } else if (steps == 57) {
                return new Vector2Int(-1, 0);
            } else {
                return new Vector2Int(0, 0);
            }
        } else if (color == "Blue") {
            if (steps == 0) {
                if (ordinal == 1) {
                    return new Vector2Int(5, 4);
                } else if (ordinal == 2) {
                    return new Vector2Int(4, 4);
                } else if (ordinal == 3) {
                    return new Vector2Int(5, 5);
                } else if (ordinal == 4) {
                    return new Vector2Int(4, 5);
                } else {
                    return new Vector2Int(0, 0);
                }
            } else if (steps == 1) {
                return new Vector2Int(1, 6);
            } else if (steps == 2) {
                return new Vector2Int(1, 5);
            } else if (steps == 3) {
                return new Vector2Int(1, 4);
            } else if (steps == 4) {
                return new Vector2Int(1, 3);
            } else if (steps == 5) {
                return new Vector2Int(1, 2);
            } else if (steps == 6) {
                return new Vector2Int(2, 1);
            } else if (steps == 7) {
                return new Vector2Int(3, 1);
            } else if (steps == 8) {
                return new Vector2Int(4, 1);
            } else if (steps == 9) {
                return new Vector2Int(5, 1);
            } else if (steps == 10) {
                return new Vector2Int(6, 1);
            } else if (steps == 11) {
                return new Vector2Int(7, 1);
            } else if (steps == 12) {
                return new Vector2Int(7, 0);
            } else if (steps == 13) {
                return new Vector2Int(7, -1);
            } else if (steps == 14) {
                return new Vector2Int(6, -1);
            } else if (steps == 15) {
                return new Vector2Int(5, -1);
            } else if (steps == 16) {
                return new Vector2Int(4, -1);
            } else if (steps == 17) {
                return new Vector2Int(3, -1);
            } else if (steps == 18) {
                return new Vector2Int(2, -1);
            } else if (steps == 19) {
                return new Vector2Int(1, -2);
            } else if (steps == 20) {
                return new Vector2Int(1, -3);
            } else if (steps == 21) {
                return new Vector2Int(1, -4);
            } else if (steps == 22) {
                return new Vector2Int(1, -5);
            } else if (steps == 23) {
                return new Vector2Int(1, -6);
            } else if (steps == 24) {
                return new Vector2Int(1, -7);
            } else if (steps == 25) {
                return new Vector2Int(0, -7);
            } else if (steps == 26) {
                return new Vector2Int(-1, -7);
            } else if (steps == 27) {
                return new Vector2Int(-1, -6);
            } else if (steps == 28) {
                return new Vector2Int(-1, -5);
            } else if (steps == 29) {
                return new Vector2Int(-1, -4);
            } else if (steps == 30) {
                return new Vector2Int(-1, -3);
            } else if (steps == 31) {
                return new Vector2Int(-1, -2);
            } else if (steps == 32) {
                return new Vector2Int(-2, -1);
            } else if (steps == 33) {
                return new Vector2Int(-3, -1);
            } else if (steps == 34) {
                return new Vector2Int(-4, -1);
            } else if (steps == 35) {
                return new Vector2Int(-5, -1);
            } else if (steps == 36) {
                return new Vector2Int(-6, -1);
            } else if (steps == 37) {
                return new Vector2Int(-7, -1);
            } else if (steps == 38) {
                return new Vector2Int(-7, 0);
            } else if (steps == 39) {
                return new Vector2Int(-7, 1);
            } else if (steps == 40) {
                return new Vector2Int(-6, 1);
            } else if (steps == 41) {
                return new Vector2Int(-5, 1);
            } else if (steps == 42) {
                return new Vector2Int(-4, 1);
            } else if (steps == 43) {
                return new Vector2Int(-3, 1);
            } else if (steps == 44) {
                return new Vector2Int(-2, 1);
            } else if (steps == 45) {
                return new Vector2Int(-1, 2);
            } else if (steps == 46) {
                return new Vector2Int(-1, 3);
            } else if (steps == 47) {
                return new Vector2Int(-1, 4);
            } else if (steps == 48) {
                return new Vector2Int(-1, 5);
            } else if (steps == 49) {
                return new Vector2Int(-1, 6);
            } else if (steps == 50) {
                return new Vector2Int(-1, 7);
            } else if (steps == 51) {
                return new Vector2Int(0, 7);
            } else if (steps == 52) {
                return new Vector2Int(0, 6);
            } else if (steps == 53) {
                return new Vector2Int(0, 5);
            } else if (steps == 54) {
                return new Vector2Int(0, 4);
            } else if (steps == 55) {
                return new Vector2Int(0, 3);
            } else if (steps == 56) {
                return new Vector2Int(0, 2);
            } else if (steps == 57) {
                return new Vector2Int(0, 1);
            } else {
                return new Vector2Int(0, 0);
            }
        } else {
            return new Vector2Int(0, 0);
        }

    }

    public static Color color(string color) {
        if (color == "Red") {
            return new Color(0.8f, 0f, 0f);
        } else if (color == "Yellow") {
            return new Color(0.8f, 0.8f, 0f);
        } else if (color == "Green") {
            return new Color(0f, 0.8f, 0f);
        } else if (color == "Blue") {
            return new Color(0f, 0f, 0.8f);
        } else {
            return new Color(0f, 0f, 0f);
        }

    }
}
