/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
namespace Amazon.Runtime
{
    /// <summary>
    /// This class  is used to configure the thread on which the callback should 
    /// be execute for a given request and pass optional state to the callback.
    /// </summary>
    public class AsyncOptions
    {
        public AsyncOptions()
        {
            this.ExecuteCallbackOnMainThread = true;
        }

        /// <summary>
        /// This property specifies if the callback for the request is executed 
        /// on the main or background thread. The default value for this property is true.
        /// </summary>
        public bool ExecuteCallbackOnMainThread { get; set; }


        /// <summary>
        /// This property gets or sets the user defined state object 
        /// that is passed to the callback.
        /// </summary>
        public object State { get; set; }
    }
}