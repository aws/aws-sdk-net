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

using System;
using Amazon.Runtime;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Returns information about the RotateEncryptionKeyResult response and response metadata.
    /// </summary>
    public class RotateEncryptionKeyResponse : AmazonWebServiceResponse
    {
        private RotateEncryptionKeyResult _rotateEncryptionKeyResult;

        /// <summary>
        /// Gets and sets the RotateEncryptionKeyResult property.
        /// Represents the output of a RotateEncryptionKey operation.
        /// </summary>
        public RotateEncryptionKeyResult RotateEncryptionKeyResult
        {
            get
            {
                if(this._rotateEncryptionKeyResult == null)
                {
                    this._rotateEncryptionKeyResult = new RotateEncryptionKeyResult();
                }
                return this._rotateEncryptionKeyResult;
            }
            set { this._rotateEncryptionKeyResult = value; }
        }
    }
}