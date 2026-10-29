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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes an Connect Customer client add-in.
    /// </summary>
    public partial class ConnectClientAddIn
    {
        /// <summary>
        /// Gets and sets the property AddInId. 
        /// <para>
        /// The client add-in identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string AddInId { get; set; }

        /// <summary>
        /// Checks to see if the AddInId property is set.
        /// </summary>
        internal bool IsSetAddInId() => this.AddInId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the client add in.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The directory identifier for which the client add-in is configured.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 65)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property URL. 
        /// <para>
        /// The endpoint URL of the client add-in.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string URL { get; set; }

        /// <summary>
        /// Checks to see if the URL property is set.
        /// </summary>
        internal bool IsSetURL() => this.URL != null;
    }
}
