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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// The framework-specific details of the assessed resource. Exactly one member is set,
    /// corresponding to the framework that was assessed.
    /// </summary>
    public partial class FrameworkSummary
    {
        private AMISecuritySummary _amiSecuritySummary;
        private ContainerSecuritySummary _containerSecuritySummary;

        /// <summary>
        /// Gets and sets the property AMISecuritySummary. 
        /// <para>
        /// The details of the resource assessed under the AMI Security framework.
        /// </para>
        /// </summary>
        public AMISecuritySummary AMISecuritySummary
        {
            get { return this._amiSecuritySummary; }
            set { this._amiSecuritySummary = value; }
        }

        // Check to see if AMISecuritySummary property is set
        internal bool IsSetAMISecuritySummary()
        {
            return this._amiSecuritySummary != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerSecuritySummary. 
        /// <para>
        /// The details of the resource assessed under the Container Security framework.
        /// </para>
        /// </summary>
        public ContainerSecuritySummary ContainerSecuritySummary
        {
            get { return this._containerSecuritySummary; }
            set { this._containerSecuritySummary = value; }
        }

        // Check to see if ContainerSecuritySummary property is set
        internal bool IsSetContainerSecuritySummary()
        {
            return this._containerSecuritySummary != null;
        }

    }
}