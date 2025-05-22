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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeNotebookInstanceLifecycleConfig operation.
    /// Returns a description of a notebook instance lifecycle configuration.
    /// 
    ///  
    /// <para>
    /// For information about notebook instance lifestyle configurations, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/notebook-lifecycle-config.html">Step
    /// 2.1: (Optional) Customize a Notebook Instance</a>.
    /// </para>
    /// </summary>
    public partial class DescribeNotebookInstanceLifecycleConfigRequest : AmazonSageMakerRequest
    {
        private string _notebookInstanceLifecycleConfigName;

        /// <summary>
        /// Gets and sets the property NotebookInstanceLifecycleConfigName. 
        /// <para>
        /// The name of the lifecycle configuration to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string NotebookInstanceLifecycleConfigName
        {
            get { return this._notebookInstanceLifecycleConfigName; }
            set { this._notebookInstanceLifecycleConfigName = value; }
        }

        // Check to see if NotebookInstanceLifecycleConfigName property is set
        internal bool IsSetNotebookInstanceLifecycleConfigName()
        {
            return this._notebookInstanceLifecycleConfigName != null;
        }

    }
}