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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// This is the response object from the TakeRouterInput operation.
    /// </summary>
    public partial class TakeRouterInputResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property RoutedState. 
        /// <para>
        /// The state of the association between the router input and output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouterOutputRoutedState RoutedState { get; set; }

        /// <summary>
        /// Checks to see if the RoutedState property is set.
        /// </summary>
        internal bool IsSetRoutedState() => this.RoutedState != null;

        /// <summary>
        /// Gets and sets the property RouterInputArn. 
        /// <para>
        /// The ARN of the associated router input.
        /// </para>
        /// </summary>
        public string RouterInputArn { get; set; }

        /// <summary>
        /// Checks to see if the RouterInputArn property is set.
        /// </summary>
        internal bool IsSetRouterInputArn() => this.RouterInputArn != null;

        /// <summary>
        /// Gets and sets the property RouterInputName. 
        /// <para>
        /// The name of the associated router input.
        /// </para>
        /// </summary>
        public string RouterInputName { get; set; }

        /// <summary>
        /// Checks to see if the RouterInputName property is set.
        /// </summary>
        internal bool IsSetRouterInputName() => this.RouterInputName != null;

        /// <summary>
        /// Gets and sets the property RouterOutputArn. 
        /// <para>
        /// The ARN of the associated router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RouterOutputArn { get; set; }

        /// <summary>
        /// Checks to see if the RouterOutputArn property is set.
        /// </summary>
        internal bool IsSetRouterOutputArn() => this.RouterOutputArn != null;

        /// <summary>
        /// Gets and sets the property RouterOutputName. 
        /// <para>
        /// The name of the associated router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RouterOutputName { get; set; }

        /// <summary>
        /// Checks to see if the RouterOutputName property is set.
        /// </summary>
        internal bool IsSetRouterOutputName() => this.RouterOutputName != null;
    }
}
