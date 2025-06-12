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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// Describes a data repository association's automatic export policy. The <c>AutoExportPolicy</c>
    /// defines the types of updated objects on the file system that will be automatically
    /// exported to the data repository. As you create, modify, or delete files, Amazon FSx
    /// for Lustre automatically exports the defined changes asynchronously once your application
    /// finishes modifying the file.
    /// 
    ///  
    /// <para>
    /// The <c>AutoExportPolicy</c> is only supported on Amazon FSx for Lustre file systems
    /// with a data repository association.
    /// </para>
    /// </summary>
    public partial class AutoExportPolicy
    {
        private List<string> _events = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// The <c>AutoExportPolicy</c> can have the following event values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NEW</c> - New files and directories are automatically exported to the data repository
        /// as they are added to the file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CHANGED</c> - Changes to files and directories on the file system are automatically
        /// exported to the data repository.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c> - Files and directories are automatically deleted on the data repository
        /// when they are deleted on the file system.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can define any combination of event types for your <c>AutoExportPolicy</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=3)]
        public List<string> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && (this._events.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}