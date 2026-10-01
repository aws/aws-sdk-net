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

namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLayout operation. Updates the attributes
    /// of an existing layout. <para> If the action is successful, the service sends back
    /// an HTTP 200 response with an empty HTTP body. </para> <para> A <c>ValidationException</c>
    /// is returned when you add non-existent <c>fieldIds</c> to a layout. </para> <note>
    /// <para> Title and Status fields cannot be part of layouts because they are not configurable.
    /// </para> </note>
    /// </summary>
    public partial class UpdateLayoutRequest : AmazonConnectCasesRequest
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Information about which fields will be present in the layout, the order of the fields.
        /// </para>
        /// </summary>
        public LayoutContent Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The unique identifier of the Cases domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property LayoutId. 
        /// <para>
        /// The unique identifier of the layout.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string LayoutId { get; set; }

        /// <summary>
        /// Checks to see if the LayoutId property is set.
        /// </summary>
        internal bool IsSetLayoutId() => this.LayoutId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the layout. It must be unique per domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
