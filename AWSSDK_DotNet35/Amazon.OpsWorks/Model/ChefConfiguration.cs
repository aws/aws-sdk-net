/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Describes the Chef configuration.</para>
    /// </summary>
    public partial class ChefConfiguration
    {
        
        private bool? manageBerkshelf;
        private string berkshelfVersion;


        /// <summary>
        /// Whether to enable Berkshelf.
        ///  
        /// </summary>
        public bool ManageBerkshelf
        {
            get { return this.manageBerkshelf ?? default(bool); }
            set { this.manageBerkshelf = value; }
        }

        // Check to see if ManageBerkshelf property is set
        internal bool IsSetManageBerkshelf()
        {
            return this.manageBerkshelf.HasValue;
        }

        /// <summary>
        /// The Berkshelf version.
        ///  
        /// </summary>
        public string BerkshelfVersion
        {
            get { return this.berkshelfVersion; }
            set { this.berkshelfVersion = value; }
        }

        // Check to see if BerkshelfVersion property is set
        internal bool IsSetBerkshelfVersion()
        {
            return this.berkshelfVersion != null;
        }
    }
}
