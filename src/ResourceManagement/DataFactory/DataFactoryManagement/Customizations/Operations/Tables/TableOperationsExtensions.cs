﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.DataFactories.Common.Models;
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories
{
    public static class TableOperationsExtensions
    {
        /// <summary>
        /// Create a new table instance or update an existing instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ITableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a table.
        /// </param>
        /// <returns>
        /// The CreateOrUpdate table operation response.
        /// </returns>
        public static TableCreateOrUpdateResponse BeginCreateOrUpdate(
            this ITableOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            TableCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew(
                    s => ((ITableOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, dataFactoryName, parameters),
                    operations,
                    CancellationToken.None,
                    TaskCreationOptions.None,
                    TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a new table instance or update an existing instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ITableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a table.
        /// </param>
        /// <returns>
        /// The CreateOrUpdate table operation response.
        /// </returns>
        public static Task<TableCreateOrUpdateResponse> BeginCreateOrUpdateAsync(
            this ITableOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            TableCreateOrUpdateParameters parameters)
        {
            return operations.BeginCreateOrUpdateAsync(
                resourceGroupName,
                dataFactoryName,
                parameters,
                CancellationToken.None);
        }

        /// <summary>
        /// Create a new table instance or update an existing instance 
        /// with raw JSON content.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ITableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='tableName'>
        /// Required. A unique table instance name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a table.
        /// </param>
        /// <returns>
        /// The CreateOrUpdate table operation response.
        /// </returns>
        public static TableCreateOrUpdateResponse BeginCreateOrUpdateWithRawJsonContent(
            this ITableOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            string tableName,
            TableCreateOrUpdateWithRawJsonContentParameters parameters)
        {
            return Task.Factory.StartNew(
                    s => ((ITableOperations)s).BeginCreateOrUpdateWithRawJsonContentAsync(
                        resourceGroupName,
                        dataFactoryName,
                        tableName,
                        parameters),
                    operations,
                    CancellationToken.None,
                    TaskCreationOptions.None,
                    TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a new table instance or update an existing instance 
        /// with raw JSON content.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ITableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='tableName'>
        /// Required. A unique table instance name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a table.
        /// </param>
        /// <returns>
        /// The CreateOrUpdate table operation response.
        /// </returns>
        public static Task<TableCreateOrUpdateResponse> BeginCreateOrUpdateWithRawJsonContentAsync(
            this ITableOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            string tableName,
            TableCreateOrUpdateWithRawJsonContentParameters parameters)
        {
            return operations.BeginCreateOrUpdateWithRawJsonContentAsync(
                resourceGroupName,
                dataFactoryName,
                tableName,
                parameters,
                CancellationToken.None);
        }

        /// <summary>
        /// Delete a table instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ITableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='tableName'>
        /// Required. Name of the table.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse BeginDelete(
            this ITableOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            string tableName)
        {
            return Task.Factory.StartNew(
                    s => ((ITableOperations)s).BeginDeleteAsync(resourceGroupName, dataFactoryName, tableName),
                    operations,
                    CancellationToken.None,
                    TaskCreationOptions.None,
                    TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a table instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ITableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='tableName'>
        /// Required. Name of the table.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> BeginDeleteAsync(
            this ITableOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            string tableName)
        {
            return operations.BeginDeleteAsync(resourceGroupName, dataFactoryName, tableName, CancellationToken.None);
        }

        /// <summary>
        /// Create a new table instance or update an existing instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ITableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a table.
        /// </param>
        /// <returns>
        /// The CreateOrUpdate table operation response.
        /// </returns>
        public static TableCreateOrUpdateResponse CreateOrUpdate(
            this ITableOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            TableCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew(
                    s => ((ITableOperations)s).CreateOrUpdateAsync(resourceGroupName, dataFactoryName, parameters),
                    operations,
                    CancellationToken.None,
                    TaskCreationOptions.None,
                    TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a new table instance or update an existing instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ITableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a table.
        /// </param>
        /// <returns>
        /// The CreateOrUpdate table operation response.
        /// </returns>
        public static Task<TableCreateOrUpdateResponse> CreateOrUpdateAsync(
            this ITableOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            TableCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(
                resourceGroupName,
                dataFactoryName,
                parameters,
                CancellationToken.None);
        }

        /// <summary>
        /// Create a new table instance or update an existing instance with raw
        /// json content.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ITableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='tableName'>
        /// Required. A unique table instance name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a table.
        /// </param>
        /// <returns>
        /// The CreateOrUpdate table operation response.
        /// </returns>
        public static TableCreateOrUpdateResponse CreateOrUpdateWithRawJsonContent(
            this ITableOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            string tableName,
            TableCreateOrUpdateWithRawJsonContentParameters parameters)
        {
            return Task.Factory.StartNew(
                    s => ((ITableOperations)s).CreateOrUpdateWithRawJsonContentAsync(
                        resourceGroupName,
                        dataFactoryName,
                        tableName,
                        parameters),
                    operations,
                    CancellationToken.None,
                    TaskCreationOptions.None,
                    TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a new table instance or update an existing instance with raw
        /// json content.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ITableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='tableName'>
        /// Required. A unique table instance name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a table.
        /// </param>
        /// <returns>
        /// The CreateOrUpdate table operation response.
        /// </returns>
        public static Task<TableCreateOrUpdateResponse> CreateOrUpdateWithRawJsonContentAsync(
            this ITableOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            string tableName,
            TableCreateOrUpdateWithRawJsonContentParameters parameters)
        {
            return operations.CreateOrUpdateWithRawJsonContentAsync(
                resourceGroupName,
                dataFactoryName,
                tableName,
                parameters,
                CancellationToken.None);
        }

        /// <summary>
        /// Delete a table instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ITableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='tableName'>
        /// Required. Name of the table.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse Delete(
            this ITableOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            string tableName)
        {
            return Task.Factory.StartNew(
                    s => ((ITableOperations)s).DeleteAsync(resourceGroupName, dataFactoryName, tableName),
                    operations,
                    CancellationToken.None,
                    TaskCreationOptions.None,
                    TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a table instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ITableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='tableName'>
        /// Required. Name of the table.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> DeleteAsync(
            this ITableOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            string tableName)
        {
            return operations.DeleteAsync(resourceGroupName, dataFactoryName, tableName, CancellationToken.None);
        }

        /// <summary>
        /// Gets a table instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ITableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='tableName'>
        /// Required. Name of the table.
        /// </param>
        /// <returns>
        /// The Get table operation response.
        /// </returns>
        public static TableGetResponse Get(
            this ITableOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            string tableName)
        {
            return Task.Factory.StartNew(
                    s => ((ITableOperations)s).GetAsync(resourceGroupName, dataFactoryName, tableName),
                    operations,
                    CancellationToken.None,
                    TaskCreationOptions.None,
                    TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets a table instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ITableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='tableName'>
        /// Required. Name of the table.
        /// </param>
        /// <returns>
        /// The Get table operation response.
        /// </returns>
        public static Task<TableGetResponse> GetAsync(
            this ITableOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            string tableName)
        {
            return operations.GetAsync(resourceGroupName, dataFactoryName, tableName, CancellationToken.None);
        }

        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ITableOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <returns>
        /// The CreateOrUpdate table operation response.
        /// </returns>
        public static TableCreateOrUpdateResponse GetCreateOrUpdateStatus(
            this ITableOperations operations,
            string operationStatusLink)
        {
            return Task.Factory.StartNew(
                    s => ((ITableOperations)s).GetCreateOrUpdateStatusAsync(operationStatusLink),
                    operations,
                    CancellationToken.None,
                    TaskCreationOptions.None,
                    TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ITableOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <returns>
        /// The CreateOrUpdate table operation response.
        /// </returns>
        public static Task<TableCreateOrUpdateResponse> GetCreateOrUpdateStatusAsync(
            this ITableOperations operations,
            string operationStatusLink)
        {
            return operations.GetCreateOrUpdateStatusAsync(operationStatusLink, CancellationToken.None);
        }

        /// <summary>
        /// Gets all the table instances in a data factory with the link to the
        /// next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ITableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <returns>
        /// The List tables operation response.
        /// </returns>
        public static TableListResponse List(
            this ITableOperations operations,
            string resourceGroupName,
            string dataFactoryName)
        {
            return Task.Factory.StartNew(
                    s => ((ITableOperations)s).ListAsync(resourceGroupName, dataFactoryName),
                    operations,
                    CancellationToken.None,
                    TaskCreationOptions.None,
                    TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets all the table instances in a data factory with the link to the
        /// next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ITableOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <returns>
        /// The List tables operation response.
        /// </returns>
        public static Task<TableListResponse> ListAsync(
            this ITableOperations operations,
            string resourceGroupName,
            string dataFactoryName)
        {
            return operations.ListAsync(resourceGroupName, dataFactoryName, CancellationToken.None);
        }

        /// <summary>
        /// Gets the next page of table instances with the link to the next
        /// page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ITableOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The url to the next tables page.
        /// </param>
        /// <returns>
        /// The List tables operation response.
        /// </returns>
        public static TableListResponse ListNext(this ITableOperations operations, string nextLink)
        {
            return Task.Factory.StartNew(
                    s => ((ITableOperations)s).ListNextAsync(nextLink),
                    operations,
                    CancellationToken.None,
                    TaskCreationOptions.None,
                    TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the next page of table instances with the link to the next
        /// page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ITableOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The url to the next tables page.
        /// </param>
        /// <returns>
        /// The List tables operation response.
        /// </returns>
        public static Task<TableListResponse> ListNextAsync(this ITableOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
    }
}
