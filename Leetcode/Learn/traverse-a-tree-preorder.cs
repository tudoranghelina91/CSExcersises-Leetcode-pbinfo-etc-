// https://leetcode.com/explore/learn/card/data-structure-tree/134/traverse-a-tree/928/
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    IList<int> nodes = new List<int>();
    public IList<int> PreorderTraversal(TreeNode root) {
            if (root != null)
            {
                nodes.Add(root.val);
                if (root.left != null)
                {
                    PreorderTraversal(root.left);
                }

                if (root.right != null)
                {
                    PreorderTraversal(root.right);
                }
            }
        return nodes;
        
    }
}
