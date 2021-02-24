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
    public IList<int> InorderTraversal(TreeNode root) {
        if (root != null)
        {
            if (root.left != null)
            {
                InorderTraversal(root.left);
            }
            
            nodes.Add(root.val);
            
            if (root.right != null)
            {
                InorderTraversal(root.right);
            }
        }
        
        return nodes;
    }
}
