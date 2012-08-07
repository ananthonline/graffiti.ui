#region License and Copyright Notice
// Copyright (c) 2010 Ananth Balasubramaniam
// All rights reserved.
// 
// The contents of this file are made available under the terms of the
// Eclipse Public License v1.0 (the "License") which accompanies this
// distribution, and is available at the following URL:
// http://www.opensource.org/licenses/eclipse-1.0.php
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either expressed or implied. See the License for
// the specific language governing rights and limitations under the License.
// 
// By using this software in any fashion, you are agreeing to be bound by the
// terms of the License.
#endregion

using System;
using System.Collections.Generic;
using Graffiti.Core.Rendering;
using Microsoft.Xna.Framework;

namespace Graffiti.UI
{
    public sealed class Style: IResourceTreeNode
    {
        private ResourceDictionary _resources;
        public Dictionary<Trigger, Setters> Triggers { get; set; }

        #region IResourceTreeNode Members

        IResourceTreeNode IResourceTreeNode.Parent { get; set; }

        public ResourceDictionary Resources
        {
            get { return _resources; }
            set
            {
                _resources = value;
                if (_resources != null)
                    _resources.Owner = this;
            }
        }

        #endregion

        public Action<UIElement, IRenderer, Matrix> Draw { get; set; }
    }
}