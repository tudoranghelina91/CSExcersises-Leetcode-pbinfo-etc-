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
    List<int> nodes = new List<int>();
    public IList<int> PostorderTraversal(TreeNode root) {
        if (root != null)
        {
            if (root.left != null)
            {
                PostorderTraversal(root.left);
            }
            
            if (root.right != null)
            {
                PostorderTraversal(root.right);
            }
            
            nodes.Add(root.val);
        }
        
        return nodes;
    }
}
