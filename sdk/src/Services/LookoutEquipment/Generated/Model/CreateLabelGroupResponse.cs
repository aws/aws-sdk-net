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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// This is the response object from the CreateLabelGroup operation.
    /// </summary>
    public partial class CreateLabelGroupResponse : AmazonWebServiceResponse
    {
        private string _labelGroupArn;
        private string _labelGroupName;

        /// <summary>
        /// Gets and sets the property LabelGroupArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the label group that you have created. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string LabelGroupArn
        {
            get { return this._labelGroupArn; }
            set { this._labelGroupArn = value; }
        }

        // Check to see if LabelGroupArn property is set
        internal bool IsSetLabelGroupArn()
        {
            return this._labelGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property LabelGroupName. 
        /// <para>
        ///  The name of the label group that you have created. Data in this field will be retained
        /// for service usage. Follow best practices for the security of your data. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string LabelGroupName
        {
            get { return this._labelGroupName; }
            set { this._labelGroupName = value; }
        }

        // Check to see if LabelGroupName property is set
        internal bool IsSetLabelGroupName()
        {
            return this._labelGroupName != null;
        }

    }
}