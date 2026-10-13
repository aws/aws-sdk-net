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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the TestConnection operation. Tests a connection to
    /// a service to validate the service credentials that you provide. <para> You can either
    /// provide an existing connection name or a <c>TestConnectionInput</c> for testing a
    /// non-existing connection input. Providing both at the same time will cause an error.
    /// </para> <para> If the action is successful, the service sends back an HTTP 200 response.
    /// </para>
    /// </summary>
    public partial class TestConnectionRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The catalog ID where the connection resides.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// Optional. The name of the connection to test. If only name is provided, the operation
        /// will get the connection and use that for testing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionName property is set.
        /// </summary>
        internal bool IsSetConnectionName() => this.ConnectionName != null;

        /// <summary>
        /// Gets and sets the property TestConnectionInput. 
        /// <para>
        /// A structure that is used to specify testing a connection to a service.
        /// </para>
        /// </summary>
        public TestConnectionInput TestConnectionInput { get; set; }

        /// <summary>
        /// Checks to see if the TestConnectionInput property is set.
        /// </summary>
        internal bool IsSetTestConnectionInput() => this.TestConnectionInput != null;
    }
}
