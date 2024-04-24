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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// This is the response object from the AssociateAppBlockBuilderAppBlock operation.
    /// </summary>
    public partial class AssociateAppBlockBuilderAppBlockResponse : AmazonWebServiceResponse
    {
        private AppBlockBuilderAppBlockAssociation _appBlockBuilderAppBlockAssociation;

        /// <summary>
        /// Gets and sets the property AppBlockBuilderAppBlockAssociation. 
        /// <para>
        /// The list of app block builders associated with app blocks.
        /// </para>
        /// </summary>
        public AppBlockBuilderAppBlockAssociation AppBlockBuilderAppBlockAssociation
        {
            get { return this._appBlockBuilderAppBlockAssociation; }
            set { this._appBlockBuilderAppBlockAssociation = value; }
        }

        // Check to see if AppBlockBuilderAppBlockAssociation property is set
        internal bool IsSetAppBlockBuilderAppBlockAssociation()
        {
            return this._appBlockBuilderAppBlockAssociation != null;
        }

    }
}