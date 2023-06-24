/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ecr-public-2020-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECRPublic.Model
{
    /// <summary>
    /// An object representing the aliases for a public registry. A public registry is given
    /// an alias when it's created. However, a custom alias can be set using the Amazon ECR
    /// console. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/Registries.html">Registries</a>
    /// in the <i>Amazon Elastic Container Registry User Guide</i>.
    /// </summary>
    public partial class RegistryAlias
    {
        private bool? _defaultRegistryAlias;
        private string _name;
        private bool? _primaryRegistryAlias;
        private RegistryAliasStatus _status;

        /// <summary>
        /// Gets and sets the property DefaultRegistryAlias. 
        /// <para>
        /// Indicates whether the registry alias is the default alias for the registry. When the
        /// first public repository is created, your public registry is assigned a default registry
        /// alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool DefaultRegistryAlias
        {
            get { return this._defaultRegistryAlias.GetValueOrDefault(); }
            set { this._defaultRegistryAlias = value; }
        }

        // Check to see if DefaultRegistryAlias property is set
        internal bool IsSetDefaultRegistryAlias()
        {
            return this._defaultRegistryAlias.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the registry alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=50)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryRegistryAlias. 
        /// <para>
        /// Indicates whether the registry alias is the primary alias for the registry. If true,
        /// the alias is the primary registry alias and is displayed in both the repository URL
        /// and the image URI used in the <code>docker pull</code> commands on the Amazon ECR
        /// Public Gallery.
        /// </para>
        ///  <note> 
        /// <para>
        /// A registry alias that isn't the primary registry alias can be used in the repository
        /// URI in a <code>docker pull</code> command.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool PrimaryRegistryAlias
        {
            get { return this._primaryRegistryAlias.GetValueOrDefault(); }
            set { this._primaryRegistryAlias = value; }
        }

        // Check to see if PrimaryRegistryAlias property is set
        internal bool IsSetPrimaryRegistryAlias()
        {
            return this._primaryRegistryAlias.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the registry alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RegistryAliasStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}