﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MonoGame.Tools.Pipeline
{
    public static class TreeViewExtensions
    {
        public static List<TreeNode> AllNodes(this TreeView tree)
        {
            var list = new List<TreeNode>();
            AddTreeNodesRecursive(tree.Nodes, list);
            return list;
        }

        private static void AddTreeNodesRecursive(TreeNodeCollection nodeCollection, List<TreeNode> results)
        {
            foreach (var i in nodeCollection)
            {
                var node = i as TreeNode;
                results.Add(node);

                AddTreeNodesRecursive(node.Nodes, results);
            }
        }
    }

}
