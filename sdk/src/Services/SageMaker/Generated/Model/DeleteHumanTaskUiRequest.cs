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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteHumanTaskUi operation.
    /// Use this operation to delete a human task user interface (worker task template).
    /// 
    ///  
    /// <para>
    ///  To see a list of human task user interfaces (work task templates) in your account,
    /// use . When you delete a worker task template, it no longer appears when you call <code>ListHumanTaskUis</code>.
    /// </para>
    /// </summary>
    public partial class DeleteHumanTaskUiRequest : AmazonSageMakerRequest
    {
        private string _humanTaskUiName;

        /// <summary>
        /// Gets and sets the property HumanTaskUiName. 
        /// <para>
        /// The name of the human task user interface (work task template) you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string HumanTaskUiName
        {
            get { return this._humanTaskUiName; }
            set { this._humanTaskUiName = value; }
        }

        // Check to see if HumanTaskUiName property is set
        internal bool IsSetHumanTaskUiName()
        {
            return this._humanTaskUiName != null;
        }

    }
}