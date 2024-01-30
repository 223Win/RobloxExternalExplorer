using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobloxExternalExplorer
{
    public partial class Explorer : Form
    {
        string RobloxCacheStorage = $@"C:\Users\{Environment.UserName}\AppData\Local\Temp\Roblox";
        private ImageList ImageAssets;

        private Dictionary<string, int> TreeNodes = new Dictionary<string, int>();
        public Explorer()
        {
            InitializeComponent();
            if (Directory.Exists(RobloxCacheStorage) == false)
            {
                throw new Exception("Cannot Find ROBLOX CACHE, Please Check If Roblox Is Installed Or Reinstall The Program");
            }
            string AudioCache = $@"{RobloxCacheStorage}\sounds";
            string HttpsCache = $@"{RobloxCacheStorage}\http";
            ImageAssets = new ImageList();

            ImageAssets.Images.Add("SOUND", Properties.Resources.Sound);
            ImageAssets.Images.Add("HTTPS", Properties.Resources.Https);
            ImageAssets.Images.Add("FILE", Properties.Resources.File);
            ExplorerTree.ImageList = ImageAssets;
            int CreateSuperClass(string Name, int ImageIndex)
            {
                int Info = ExplorerTree.Nodes.Add(new TreeNode(Name, imageIndex: ImageIndex, ImageIndex));
                TreeNodes[Name] = Info;
                return Info;
            }

            void ResetTree()
            {
                ExplorerTree.Nodes.Clear();
                CreateSuperClass("Audio", 0);
                CreateSuperClass("Https", 1);
            }

            void ClearSuperClass(string SuperClass)
            {
                TreeNode Node = ExplorerTree.Nodes[TreeNodes[SuperClass]];

                Node.Nodes.Clear();
            }

            void AddNodeToSuperClass(string SuperClass, string Name, string FilePath)
            {
                TreeNode Node = ExplorerTree.Nodes[TreeNodes[SuperClass]];

                int NodeIndex = Node.Nodes.Add(new TreeNode(Name, imageIndex: 2, selectedImageIndex: 2));

                Node.Nodes[NodeIndex].Tag = FilePath;

            }


            ResetTree();
            AddNodeToSuperClass("Audio", "FILE.ogg", "GAY MONSTER");
            AddNodeToSuperClass("Https", "Log.txt", "HEHEHEHAW");
            ClearSuperClass("Https");
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.FullPath != "Audio" && e.Node.FullPath != "Https")
            {
                Console.WriteLine(Environment.UserName);
                Console.WriteLine("Non SuperConstructer Node found");
                if (e.Node.FullPath.Contains("Audio"))
                {
                    Console.WriteLine("Audio File Clicked on");
                    Console.WriteLine(e.Node.Tag);
                }
                else
                {
                    Console.WriteLine("HTTP Log File Clicked on");
                    Console.WriteLine(e.Node.Tag);
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
