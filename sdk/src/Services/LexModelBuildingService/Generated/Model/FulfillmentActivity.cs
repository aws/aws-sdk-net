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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
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
namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Describes how the intent is fulfilled after the user provides all of the information
    /// required for the intent. You can provide a Lambda function to process the intent,
    /// or you can return the intent information to the client application. We recommend that
    /// you use a Lambda function so that the relevant logic lives in the Cloud and limit
    /// the client-side code primarily to presentation. If you need to update the logic, you
    /// only update the Lambda function; you don't need to upgrade your client application.
    /// 
    /// 
    ///  
    /// <para>
    /// Consider the following examples:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// In a pizza ordering application, after the user provides all of the information for
    /// placing an order, you use a Lambda function to place an order with a pizzeria. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// In a gaming application, when a user says "pick up a rock," this information must
    /// go back to the client application so that it can perform the operation and update
    /// the graphics. In this case, you want Amazon Lex to return the intent data to the client.
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class FulfillmentActivity
    {
        private CodeHook _codeHook;
        private FulfillmentActivityType _type;

        /// <summary>
        /// Gets and sets the property CodeHook. 
        /// <para>
        ///  A description of the Lambda function that is run to fulfill the intent. 
        /// </para>
        /// </summary>
        public CodeHook CodeHook
        {
            get { return this._codeHook; }
            set { this._codeHook = value; }
        }

        // Check to see if CodeHook property is set
        internal bool IsSetCodeHook()
        {
            return this._codeHook != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  How the intent should be fulfilled, either by running a Lambda function or by returning
        /// the slot data to the client application. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FulfillmentActivityType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}