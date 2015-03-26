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

/*
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Describes the Chef configuration.
    /// </summary>
    public partial class ChefConfiguration
    {
        private string _berkshelfVersion;
        private bool? _manageBerkshelf;

        /// <summary>
        /// Gets and sets the property BerkshelfVersion. 
        /// <para>
        /// The Berkshelf version.
        /// </para>
        /// </summary>
        public string BerkshelfVersion
        {
            get { return this._berkshelfVersion; }
            set { this._berkshelfVersion = value; }
        }

        // Check to see if BerkshelfVersion property is set
        internal bool IsSetBerkshelfVersion()
        {
            return this._berkshelfVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ManageBerkshelf. 
        /// <para>
        /// Whether to enable Berkshelf.
        /// </para>
        /// </summary>
        public bool ManageBerkshelf
        {
            get { return this._manageBerkshelf.GetValueOrDefault(); }
            set { this._manageBerkshelf = value; }
        }

        // Check to see if ManageBerkshelf property is set
        internal bool IsSetManageBerkshelf()
        {
            return this._manageBerkshelf.HasValue; 
        }

    }
}