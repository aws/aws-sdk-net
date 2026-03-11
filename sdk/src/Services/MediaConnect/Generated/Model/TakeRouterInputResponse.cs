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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
        private RouterOutputRoutedState _routedState;
        private string _routerInputArn;
        private string _routerInputName;
        private string _routerOutputArn;
        private string _routerOutputName;

        /// <summary>
        /// Gets and sets the property RoutedState. 
        /// <para>
        /// The state of the association between the router input and output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouterOutputRoutedState RoutedState
        {
            get { return this._routedState; }
            set { this._routedState = value; }
        }

        // Check to see if RoutedState property is set
        internal bool IsSetRoutedState()
        {
            return this._routedState != null;
        }

        /// <summary>
        /// Gets and sets the property RouterInputArn. 
        /// <para>
        /// The ARN of the associated router input.
        /// </para>
        /// </summary>
        public string RouterInputArn
        {
            get { return this._routerInputArn; }
            set { this._routerInputArn = value; }
        }

        // Check to see if RouterInputArn property is set
        internal bool IsSetRouterInputArn()
        {
            return this._routerInputArn != null;
        }

        /// <summary>
        /// Gets and sets the property RouterInputName. 
        /// <para>
        /// The name of the associated router input.
        /// </para>
        /// </summary>
        public string RouterInputName
        {
            get { return this._routerInputName; }
            set { this._routerInputName = value; }
        }

        // Check to see if RouterInputName property is set
        internal bool IsSetRouterInputName()
        {
            return this._routerInputName != null;
        }

        /// <summary>
        /// Gets and sets the property RouterOutputArn. 
        /// <para>
        /// The ARN of the associated router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RouterOutputArn
        {
            get { return this._routerOutputArn; }
            set { this._routerOutputArn = value; }
        }

        // Check to see if RouterOutputArn property is set
        internal bool IsSetRouterOutputArn()
        {
            return this._routerOutputArn != null;
        }

        /// <summary>
        /// Gets and sets the property RouterOutputName. 
        /// <para>
        /// The name of the associated router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RouterOutputName
        {
            get { return this._routerOutputName; }
            set { this._routerOutputName = value; }
        }

        // Check to see if RouterOutputName property is set
        internal bool IsSetRouterOutputName()
        {
            return this._routerOutputName != null;
        }

    }
}