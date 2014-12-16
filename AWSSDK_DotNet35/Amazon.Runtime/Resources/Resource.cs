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
using System.Globalization;
namespace Amazon.Runtime.Resources
{
    internal abstract class Resource<T>
    {
        T _client;
        private readonly object _loadLock = new object();

        public Resource(T client)
        {
            _client = client;
        }

        protected T Client { get { return _client; } }

        protected bool IsLoaded { get; set; }

        protected void CheckIfLoaded()
        {
            if (!this.IsLoaded)
            {
                lock (_loadLock)
                {
                    if (!this.IsLoaded)
                    {
                        try 
                        {
                            LoadResource();
                            this.IsLoaded = true;
                        }
                        catch (AmazonServiceException es)
                        {
                            throw new ResourceLoadException(
                                "Failed to load resource data due to a service exception. Check the inner exception for more details.", es);
                        }                        
                        catch(ObjectDisposedException objectDisposedException)
                        {
                            throw HandleObjectDisposedException("LoadResource", objectDisposedException);
                        }
                    }
                }
            }
        }

        protected virtual void LoadResource() { }

        protected ObjectDisposedException HandleObjectDisposedException(string methodName, ObjectDisposedException exception)
        {
            var message = string.Format(CultureInfo.InvariantCulture,
                "Execution of the {0} method failed as the service client associated with it has been disposed. " +
                "The resource root or the service client used to construct the resource root should not be disposed for the lifetime of " +
                "the resource objects.",
                   methodName);
            return new ObjectDisposedException(message, exception);
        }
    }
}
