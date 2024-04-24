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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
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
namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// This is the response object from the CreateConstraint operation.
    /// </summary>
    public partial class CreateConstraintResponse : AmazonWebServiceResponse
    {
        private ConstraintDetail _constraintDetail;
        private string _constraintParameters;
        private Status _status;

        /// <summary>
        /// Gets and sets the property ConstraintDetail. 
        /// <para>
        /// Information about the constraint.
        /// </para>
        /// </summary>
        public ConstraintDetail ConstraintDetail
        {
            get { return this._constraintDetail; }
            set { this._constraintDetail = value; }
        }

        // Check to see if ConstraintDetail property is set
        internal bool IsSetConstraintDetail()
        {
            return this._constraintDetail != null;
        }

        /// <summary>
        /// Gets and sets the property ConstraintParameters. 
        /// <para>
        /// The constraint parameters.
        /// </para>
        /// </summary>
        public string ConstraintParameters
        {
            get { return this._constraintParameters; }
            set { this._constraintParameters = value; }
        }

        // Check to see if ConstraintParameters property is set
        internal bool IsSetConstraintParameters()
        {
            return this._constraintParameters != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the current request.
        /// </para>
        /// </summary>
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}