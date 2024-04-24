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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLayout operation.
    /// Creates a layout in the Cases domain. Layouts define the following configuration in
    /// the top section and More Info tab of the Cases user interface:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Fields to display to the users
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Field ordering
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// Title and Status fields cannot be part of layouts since they are not configurable.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateLayoutRequest : AmazonConnectCasesRequest
    {
        private LayoutContent _content;
        private string _domainId;
        private string _name;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Information about which fields will be present in the layout, and information about
        /// the order of the fields.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LayoutContent Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The unique identifier of the Cases domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the layout. It must be unique for the Cases domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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

    }
}