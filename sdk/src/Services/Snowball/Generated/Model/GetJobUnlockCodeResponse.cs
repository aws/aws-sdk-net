/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// This is the response object from the GetJobUnlockCode operation.
    /// </summary>
    public partial class GetJobUnlockCodeResponse : AmazonWebServiceResponse
    {
        private string _unlockCode;

        /// <summary>
        /// Gets and sets the property UnlockCode. 
        /// <para>
        /// The <code>UnlockCode</code> value for the specified job. The <code>UnlockCode</code>
        /// value can be accessed for up to 90 days after the job has been created.
        /// </para>
        /// </summary>
        public string UnlockCode
        {
            get { return this._unlockCode; }
            set { this._unlockCode = value; }
        }

        // Check to see if UnlockCode property is set
        internal bool IsSetUnlockCode()
        {
            return this._unlockCode != null;
        }

    }
}