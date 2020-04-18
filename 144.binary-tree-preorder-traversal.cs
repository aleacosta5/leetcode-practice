/*
 * @lc app=leetcode id=144 lang=csharp
 *
 * [144] Binary Tree Preorder Traversal
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        IList<int> result = new List<int>();
        if (root == null) return result;
        Stack<TreeNode> s = new Stack<TreeNode>();
        s.Push(root);

        while(s.Count > 0) {
            TreeNode current = s.Pop();

            if (current.right != null) s.Push(current.right);
            if (current.left != null) s.Push(current.left);

            result.Add(current.val);
        }

        return result;
    }
}
// @lc code=end

