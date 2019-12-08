//    Copyright 2019 EPAM Systems, Inc.
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

import { FailureType, LoadingStatus } from 'Foundation/Integration/client';

import * as Commerce from 'Foundation/Commerce/client';

import * as actionCreators from './actionCreators';
import { actionTypes } from './actionTypes';

export const GetOrderHistory: actionCreators.GetOrderHistory = () => ({
  type: actionTypes.GET_ORDER_HISTORY,
});

export const OrderHistoryLoadMore: actionCreators.GetOrderHistory = () => ({
  type: actionTypes.ORDER_HISTORY_LOAD_MORE,
});

export const GetOrderHistoryRequest: actionCreators.GetOrderHistoryRequest = () => ({
  payload: {
    status: LoadingStatus.Loading,
  },
  type: actionTypes.GET_ORDER_HISTORY_REQUEST,
});

export const GetOrderHistoryFailure: FailureType = (error: string, stack?) => ({
  payload: {
    error,
    stack,
    status: LoadingStatus.Failure,
  },
  type: actionTypes.GET_ORDER_HISTORY_FAILURE,
});

export const GetOrderHistorySuccess: actionCreators.GetOrderHistorySuccess = (
  orders: Commerce.OrderModel[],
  currentPageNumber: number,
  isLastPage: boolean
) => ({
  payload: {
    currentPageNumber,
    isLastPage,
    orders,
    status: LoadingStatus.Loaded,
  },
  type: actionTypes.GET_ORDER_HISTORY_SUCCESS,
});